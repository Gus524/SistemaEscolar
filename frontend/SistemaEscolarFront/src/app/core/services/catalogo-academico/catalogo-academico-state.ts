import {computed, effect, inject, Injectable, signal} from '@angular/core';
import {MapaCurricularApi} from '@app/core/services/mapa-curricular/mapa-curricular-api';
import {InicioState} from '@app/core/services/inicio';
import {Carrera} from '@app/core/models/carrera';
import {AsyncState} from '@app/core/utils/async-state.util';
import {forkJoin, map, switchMap, tap} from 'rxjs';
import {Plan} from '@app/core/models/planes';

@Injectable({
  providedIn: 'root'
})
export class CatalogoAcademicoState {
  private api = inject(MapaCurricularApi);
  private inicio = inject(InicioState);
  private _async = new AsyncState();

  #carreras = signal<Map<string, Carrera>>(new Map());
  readonly carreras = computed(() => Array.from(this.#carreras().values()));

  #planesCache = signal<Map<string, Plan[]>>(new Map());
  readonly planes = computed(() => Array.from(this.#planesCache().values()));
  constructor() {
    effect(() => {
      const idInstitucion = this.inicio.rawData()?.idInstitucion;
      if (idInstitucion) {
        this.initCatalogo();
      }
    });
  }

  public getPlanByCarrera(carrera: string | null | undefined) {
    if (!carrera) return [];
    return this.#planesCache().get(carrera);
  }

  private initCatalogo() {
    const institucion = this.inicio.rawData()!.idInstitucion;

    const request$ = this.api.getCarreras(institucion).pipe(
      tap(carreras => {
        const map = new Map<string, Carrera>();
        carreras.forEach((c) => map.set(c.abreviatura, c));

        this.#carreras.set(map);
      }),

      switchMap(carreras => {
        if (carreras.length === 0) return forkJoin([]);
        const peticionesPlanes = carreras.map(c =>
          this.api.getPlanes(c.abreviatura).pipe(
            map(planes => ({ carrera: c.abreviatura, planes }))
          )
        );

        return forkJoin(peticionesPlanes);
      })
    );

    this._async.execute(
      request$,
      (resultados) => {
        const mapaCompleto = new Map<string, Plan[]>();

        resultados.forEach(item => {
          mapaCompleto.set(item.carrera, item.planes);
        });

        this.#planesCache.set(mapaCompleto);
      }
    );
  }
}
