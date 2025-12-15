import {computed, inject, Injectable, signal} from '@angular/core';
import {MapaCurricularApi} from '@app/core/services/mapa-curricular/mapa-curricular-api';
import {MapaCurricular, MapaCurricularFilters} from '@app/core/models/mapa-curricular';
import {AsyncState} from '@app/core/utils/async-state.util';

@Injectable({
  providedIn: 'root'
})
export class MapaCurricularState {
  private api = inject(MapaCurricularApi);
  private _async = new AsyncState();

  loading = computed(() => this._async.loading());

  #filters = signal<MapaCurricularFilters | null>(null);

  #mapa = signal<MapaCurricular[] | null>(null);
  mapa = this.#mapa.asReadonly();
  setFilters(filters: MapaCurricularFilters) {
    this.#filters.set(filters);
  }

  getMapa() {
    if (this.#filters()){
      this._async.execute(
        this.api.getMapa(this.#filters()!),
        response =>
          this.#mapa.set(response)
      );
    }
  }
}
