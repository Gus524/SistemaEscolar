import {computed, inject, Injectable, signal} from '@angular/core';
import {AuthRequest, User} from '@app/core/models';
import {AuthApi} from '@app/core/services/auth/auth-api';
import {AsyncState} from '@app/core/utils/async-state.util';
import {userAdapter} from '@app/core/adapters';
import {Router, UrlTree} from '@angular/router';
import {catchError, of, tap} from 'rxjs';
import {TokenStorage} from '@app/core/services/token/token-storage';

@Injectable({
  providedIn: 'root'
})
export class AuthState {
  private router = inject(Router);
  private api = inject(AuthApi);
  private storage = inject(TokenStorage);
  private _async = new AsyncState();

  public loading = computed(() => this._async.loading());
  public error = computed(() => this._async.error());

  #currentUser = signal<User | null>(null);
  #token = signal<string | null>(null);

  public currentUser = this.#currentUser.asReadonly();
  public isActive = computed(() => this.#token() !== null);
  public token = this.#token.asReadonly();

  login(request: AuthRequest) {
    this._async.execute(
      this.api.login(request),
      (response) => {
        this.storage.saveToken(response.token);
        this.#currentUser.set(userAdapter(response.user));
        this.#token.set(response.token);
        this.router.navigate(['/']);
      }
    )
  }

  async logout() {
    this.clearSessionData();
    await this.router.navigate(['/login']);
  }

  restoreSession() {
    const storedToken = this.storage.getToken();

    if (!storedToken) {
      this.#token.set(null);
      this.#currentUser.set(null);
      return of(true);
    }

    this.#token.set(storedToken);

    return this.api.me().pipe(
      tap(user => {
        this.#currentUser.set(userAdapter(user));
      }),
      catchError(() => {
        this.logout();
        return of(true);
      })
    );
  }

  accessDenied(): UrlTree {
    this.clearSessionData();
    return this.router.createUrlTree(['/login']);
  }

  forbidden(): UrlTree {
    return this.router.createUrlTree(['/forbbiden']);
  }

  private clearSessionData() {
    this.storage.removeToken();
    this.#token.set(null);
    this.#currentUser.set(null);
  }
}
