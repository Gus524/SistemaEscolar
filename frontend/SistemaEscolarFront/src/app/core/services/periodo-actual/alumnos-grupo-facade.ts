import {inject, Injectable, signal} from '@angular/core';
import {AsyncState} from '@app/core/utils/async-state.util';
import {PeriodoActualApi} from '@app/core/services/periodo-actual/periodo-actual-api';
import {AlumnosGrupo} from '@app/core/models/periodo-actual/alumnos-grupo.model';
import {AlumnosGrupoRequest} from '@app/core/models/periodo-actual/alumnos-grupo.request';

@Injectable()
export class AlumnosGrupoFacade {
  private api = inject(PeriodoActualApi);
  private _async = new AsyncState();

  #alumnos = signal<AlumnosGrupo[] | null>(null);
  alumnos = this.#alumnos.asReadonly();


  getAlumnosGrupo(request: AlumnosGrupoRequest) {
    this._async.execute(
      this.api.getAlumnosGrupo(request),
      response => this.#alumnos.set(response)
    );
  }
}
