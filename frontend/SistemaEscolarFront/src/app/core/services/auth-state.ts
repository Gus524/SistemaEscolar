import {computed, Injectable, signal} from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthState {
  #currentUser = signal(null);
  #token = signal(null);

  public isActive = computed(() => this.#token() !== null);
  public token = this.#token.asReadonly();
}
