import { TestBed } from '@angular/core/testing';
import { describe, it, expect, beforeEach, vi, afterEach } from 'vitest';
import { AuthState } from './auth-state';
import { AuthRequest, AuthResponse, User } from '@app/core/models';
import { TipoUsuario } from '@app/core/enums';
import { of, throwError } from 'rxjs';
import { AuthApi } from '@app/core/services/auth/auth-api';
import { Router } from '@angular/router';
import { TokenStorage } from '@app/core/services/token/token-storage';
import { provideZonelessChangeDetection } from '@angular/core';
import {UserAuthResponse} from '@app/core/models/user/user-auth.response';

const MOCK_USER: UserAuthResponse = { userName: 'Juan', tipo: TipoUsuario.alumno };
const MOCK_AUTH_RESPONSE: AuthResponse = { token: 'jwt-token', user: MOCK_USER };

describe('AuthState Service', () => {
  let service: AuthState;
  let apiMock: any;
  let routerMock: any;
  let tokenStorageMock: any;

  beforeEach(() => {
    apiMock = {
      login: vi.fn(),
      me: vi.fn()
    };

    routerMock = {
      navigate: vi.fn().mockResolvedValue(true),
      createUrlTree: vi.fn().mockReturnValue('URL_TREE')
    };

    tokenStorageMock = {
      getToken: vi.fn(),
      saveToken: vi.fn(),
      removeToken: vi.fn()
    };

    TestBed.configureTestingModule({
      providers: [
        AuthState,
        { provide: AuthApi, useValue: apiMock },
        { provide: Router, useValue: routerMock },
        { provide: TokenStorage, useValue: tokenStorageMock },
        provideZonelessChangeDetection()
      ]
    });

    service = TestBed.inject(AuthState);
  });

  afterEach(() => {
    vi.clearAllMocks();
  });

  describe('restoreSession()', () => {
    it('debe no hacer nada si no hay token en storage', () => {
      tokenStorageMock.getToken.mockReturnValue(null);

      service.restoreSession().subscribe();

      expect(service.token()).toBeNull();
      expect(apiMock.me).not.toHaveBeenCalled();
    });

    it('debe restaurar usuario si hay token y API responde OK', () => {
      tokenStorageMock.getToken.mockReturnValue('stored-token');
      apiMock.me.mockReturnValue(of(MOCK_AUTH_RESPONSE));

      service.restoreSession().subscribe();

      expect(service.token()).toBe('stored-token');
      expect(service.isActive()).toBe(true);
    });

    it('debe hacer logout si hay token pero la API falla (token invalido)', () => {
      tokenStorageMock.getToken.mockReturnValue('bad-token');
      apiMock.me.mockReturnValue(throwError(() => new Error('401')));

      const spyRemove = tokenStorageMock.removeToken;

      service.restoreSession().subscribe();

      expect(spyRemove).toHaveBeenCalled();
      expect(service.token()).toBeNull();
      expect(routerMock.navigate).toHaveBeenCalledWith(['/login']);
    });
  });

  describe('login()', () => {
    it('debe guardar token en TokenStorage y navegar', () => {
      const request: AuthRequest = { userName: '1', password: '1' };
      apiMock.login.mockReturnValue(of(MOCK_AUTH_RESPONSE));

      service.login(request);

      expect(tokenStorageMock.saveToken).toHaveBeenCalledWith('jwt-token');
      expect(service.token()).toBe('jwt-token');
      expect(routerMock.navigate).toHaveBeenCalledWith(['/']);
    });
  });

  describe('logout()', () => {
    it('debe llamar a storage.removeToken y navegar al login', async () => {
      apiMock.login.mockReturnValue(of(MOCK_AUTH_RESPONSE));
      service.login({ userName: 'a', password: 'b' });

      await service.logout();

      expect(tokenStorageMock.removeToken).toHaveBeenCalled();
      expect(service.token()).toBeNull();
      expect(routerMock.navigate).toHaveBeenCalledWith(['/login']);
    });
  });

  describe('Helpers de Guard (accessDenied / forbidden)', () => {
    it('accessDenied debe limpiar sesión y retornar UrlTree al login', () => {
      service.accessDenied();

      expect(tokenStorageMock.removeToken).toHaveBeenCalled();
      expect(routerMock.createUrlTree).toHaveBeenCalledWith(['/login']);
    });

    it('forbidden debe retornar UrlTree a /forbidden', () => {
      service.forbidden();

      expect(routerMock.createUrlTree).toHaveBeenCalledWith(['/forbbiden']);
    });
  });
});
