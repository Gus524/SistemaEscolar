import {inject, Injectable, signal} from '@angular/core';
import {HorarioApi} from '@app/core/services/horario/horario-api';
import {AsyncState} from '@app/core/utils/async-state.util';
import {HorarioTableModel} from '@app/core/models/horario';
import {horarioAdapter} from '@app/core/adapters/horario.adapter';

@Injectable()
export class AlumnoHorarioFacade {
  private api = inject(HorarioApi);
  private _async = new AsyncState();

  #horario = signal<HorarioTableModel[] | null>(null);
  horario = this.#horario.asReadonly();
  public loading = this._async.loading;
  public error = this._async.error;

  getHorario(boleta?: number) {
    this._async.execute(
      this.api.getAlumnoHorario(),
      response => {
        this.#horario.set(response.map((horarioAdapter)));
      }
    )
  }
}
