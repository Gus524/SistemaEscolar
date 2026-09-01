import {inject, Injectable, signal} from '@angular/core';
import {PeriodoActualApi} from '@app/core/services/periodo-actual/periodo-actual-api';
import {AsyncState} from '@app/core/utils/async-state.util';
import {Calificaciones} from '@app/core/models/periodo-actual/calificaciones.model';

@Injectable()
export class CalificacionesAlumnoFacade {
  private api = inject(PeriodoActualApi);
  private _async = new AsyncState();

  #calificaciones = signal<Calificaciones[] | null>(null);
  calificaciones = this.#calificaciones.asReadonly();

  public loading = this._async.loading;
  public error = this._async.error;

  getCalificaciones(boleta?: number, plan?: number) {
    this._async.execute(
      this.api.getCalificacionesAlumno(boleta, plan),
      response => this.#calificaciones.set(response)
    );
  }
}
