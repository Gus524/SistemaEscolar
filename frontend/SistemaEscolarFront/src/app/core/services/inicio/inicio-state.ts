import {computed, effect, inject, Injectable, signal} from '@angular/core';
import {InicioApi} from '@app/core/services/inicio/inicio-api';
import {AsyncState} from '@app/core/utils/async-state.util';
import {InicioType} from '@app/shared/types/inicio.type';
import {AuthState} from '@app/core/services/auth';

@Injectable({
  providedIn: 'root'
})
export class InicioState {
  private api = inject(InicioApi);
  private auth = inject(AuthState);
  private _async = new AsyncState();

  #data = signal<InicioType | null>(null);

  public loading = this._async.loading;
  public error = this._async.error;

  constructor() {
    effect(() => {
      const isActive = this.auth.isActive();

      if (isActive) {
        this.getInicio();
      } else {
        this.#data.set(null);
      }
    });
  }
  getInicio() {
    this._async.execute(
      this.api.getInicio(),
      response => {
        this.#data.set(response);
      }
    )
  }

  public as<T extends InicioType>() {
    return computed(() => this.#data() as T | null);
  }

  public rawData = this.#data.asReadonly();
}
