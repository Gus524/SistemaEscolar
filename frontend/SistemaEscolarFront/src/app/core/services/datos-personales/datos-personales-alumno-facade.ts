import {inject, Injectable, signal} from '@angular/core';
import {AsyncState} from '@app/core/utils/async-state.util';
import {DatosPersonalesApi} from '@app/core/services/datos-personales/datos-personales-api';
import {DatosPersonalesAlumno} from '@app/core/models/datos-personales/datos-alumno.model';

@Injectable()
export class DatosPersonalesAlumnoFacade {
  private api = inject(DatosPersonalesApi);
  private _async = new AsyncState();

  #datos = signal<DatosPersonalesAlumno | null>(null);
  datos = this.#datos.asReadonly();

  getDatosAlumno(boleta?: number){
    this._async.execute(
      this.api.getDatosAlumno(boleta),
      response => this.#datos.set(response)
    );
  }

}
