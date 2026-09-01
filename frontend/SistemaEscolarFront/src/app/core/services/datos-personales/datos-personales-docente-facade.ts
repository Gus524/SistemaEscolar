import {inject, Injectable, signal} from '@angular/core';
import {DatosPersonalesApi} from '@app/core/services/datos-personales/datos-personales-api';
import {AsyncState} from '@app/core/utils/async-state.util';
import {DatosPersonalesDocente} from '@app/core/models/datos-personales/datos-docente.model';

@Injectable({
  providedIn: 'root'
})
export class DatosPersonalesDocenteFacade {
  private api = inject(DatosPersonalesApi);
  private _async = new AsyncState();

  #datos = signal<DatosPersonalesDocente | null>(null);
  datos = this.#datos.asReadonly();
  error = this._async.error;

  getDatosDocente(rfc?: string){
    this._async.execute(
      this.api.getDatosDocente(rfc),
      response => this.#datos.set(response)
    );
  }
}
