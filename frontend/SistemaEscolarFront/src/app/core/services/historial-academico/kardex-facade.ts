import {inject, Injectable, signal} from '@angular/core';
import {AsyncState} from '@app/core/utils/async-state.util';
import {HistorialAcademicoApi} from '@app/core/services/historial-academico/historial-academico-api';
import {HistorialAlumnoResponse} from '@app/core/models/historial-academico';

@Injectable()
export class KardexFacade {
  private api = inject(HistorialAcademicoApi);
  private _async = new AsyncState();

  #historialDetalle = signal<HistorialAlumnoResponse | null>(null);
  historialDetalle = this.#historialDetalle.asReadonly();

  getHistorialDetalle(boleta?: number) {
    this._async.execute(
      this.api.getHistorialDetalle(boleta),
      response => this.#historialDetalle.set(response)
    );
  }
}
