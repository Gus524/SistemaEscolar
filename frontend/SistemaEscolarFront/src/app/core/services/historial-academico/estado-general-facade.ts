import {computed, inject, Injectable, signal} from '@angular/core';
import {HistorialAcademicoApi} from '@app/core/services/historial-academico/historial-academico-api';
import {AsyncState} from '@app/core/utils/async-state.util';
import {InicioState} from '@app/core/services/inicio';
import {EstadoGeneral} from '@app/core/models/historial-academico';

@Injectable()
export class EstadoGeneralFacade {
  private api = inject(HistorialAcademicoApi);
  private _async = new AsyncState();

  #estadoGeneral = signal<EstadoGeneral[] | null>(null);
  estadoGeneral = this.#estadoGeneral.asReadonly();

  getEstado(boleta: number, plan: number) {
    this._async.execute(
      this.api.getEstadoGeneral(boleta, plan),
      response => this.#estadoGeneral.set(response)
    );
  }
}
