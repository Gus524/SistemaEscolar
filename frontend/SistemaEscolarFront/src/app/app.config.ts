import {
  ApplicationConfig, inject,
  provideAppInitializer,
  provideBrowserGlobalErrorListeners,
  provideZonelessChangeDetection
} from '@angular/core';
import {provideRouter, withComponentInputBinding, withViewTransitions} from '@angular/router';
import {provideHttpClient, withFetch, withInterceptors} from '@angular/common/http';
import { routes } from './app.routes';
import {API_URL} from '@app/core/config/api.token';
import {environment} from '@env/environment';
import {tokenInterceptor} from '@app/core/interceptors/token-interceptor';
import {AuthState} from '@app/core/services/auth';

export const appConfig: ApplicationConfig = {
  providers: [
    provideBrowserGlobalErrorListeners(),
    provideZonelessChangeDetection(),
    provideRouter(routes, withComponentInputBinding(), withViewTransitions()),
    provideHttpClient(withFetch(), withInterceptors([tokenInterceptor])),
    { provide: API_URL, useValue: environment.apiUrl},
    provideAppInitializer(() => {
      const auth = inject(AuthState);
      return auth.restoreSession();
    })
  ]
};
