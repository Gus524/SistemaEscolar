import {computed, inject, Injectable, signal} from '@angular/core';
import {AuthRequest, AuthResponse} from '@app/core/models/auth';
import {User} from '@app/core/models';
import {AuthApi} from '@app/core/services/auth/auth-api';
import {AsyncState} from '@app/core/utils/async-state.util';
import {userAdapter} from '@app/core/adapters';
import {Router} from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthState {
  private router = inject(Router);
  private api = inject(AuthApi);
  private _async = new AsyncState();

  #currentUser = signal<User | null>(null);
  #token = signal<string | null>(null);

  public currentUser = this.#currentUser.asReadonly();
  public isActive = computed(() => this.#token() !== null);
  public token = this.#token.asReadonly();

  login(request: AuthRequest) {
    this._async.execute(
      this.api.login(request),
      (response) => {
        localStorage.setItem('token', response.token);
        this.#currentUser.set(userAdapter(response));
        this.#token.set(response.token);
      }
    )
  }

  async logout() {
    localStorage.removeItem('token');
    this.#token.set(null);
    this.#currentUser.set(null);

    await this.router.navigate(['/login']);
  }
}
