import {inject, Injectable, signal} from '@angular/core';
import {PeriodoActualApi} from '@app/core/services/periodo-actual';
import {AsyncState} from '@app/core/utils/async-state.util';
import {HistorialAcademicoApi} from '@app/core/services/historial-academico';
import {HistorialAlumno} from '@app/core/models/historial-academico';
import {response} from 'express';

@Injectable({
  providedIn: 'root'
})
export class HistorialAlumnoFacade {
  private api = inject(HistorialAcademicoApi);
  private _async = new AsyncState();
  error = this._async.error;

  #alumno = signal<HistorialAlumno | null>(null);
  alumno = this.#alumno.asReadonly();

  getHistorial(boleta: number) {
    this._async.execute(
      this.api.getHistorialAlumno(boleta),
      response => this.#alumno.set(response)
    );
  }
}
