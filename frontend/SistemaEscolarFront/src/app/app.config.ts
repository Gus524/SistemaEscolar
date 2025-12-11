import { ApplicationConfig, provideBrowserGlobalErrorListeners, provideZonelessChangeDetection } from '@angular/core';
import { provideClientHydration, withEventReplay, withIncrementalHydration } from '@angular/platform-browser';
import { provideRouter, withComponentInputBinding } from '@angular/router';
import {provideHttpClient, withFetch, withInterceptors} from '@angular/common/http';
import { routes } from './app.routes';
import {API_URL} from '@app/core/config/api.token';
import {environment} from '@env/environment';
import {tokenInterceptor} from '@app/core/interceptors/token-interceptor';

export const appConfig: ApplicationConfig = {
  providers: [
    provideBrowserGlobalErrorListeners(),
    provideZonelessChangeDetection(),
    provideRouter(routes, withComponentInputBinding()),
    provideHttpClient(withFetch(), withInterceptors([tokenInterceptor])),
    provideClientHydration(withEventReplay(), withIncrementalHydration()),
    { provide: API_URL, useValue: environment.apiUrl}
  ]
};
