import {TestBed} from '@angular/core/testing';
import { describe, it, expect, beforeEach, vi, afterEach } from 'vitest';

import {AuthState} from './auth-state';
import {AuthRequest, AuthResponse, User} from '@app/core/models';
import {TipoUsuario} from '@app/core/enums';
import {of} from 'rxjs';
import {AuthApi} from '@app/core/services/auth/auth-api';
import {Router} from '@angular/router';
import {provideZonelessChangeDetection} from '@angular/core';

const MOCK_USER: User = { usuario: "2020600407", nombre: 'Juan Perez', tipoUsuario: TipoUsuario.alumno };

const MOCK_AUTH_RESPONSE: AuthResponse = {
  token: 'fake-jwt-token',
  user: MOCK_USER.usuario,
  userName: MOCK_USER.nombre,
  role: MOCK_USER.tipoUsuario
};

describe('AuthState Service', () => {
  let service: AuthState;
  let apiMock: any;
  let routerMock: any;

  let localStorageMock: any;

  beforeEach(() => {
    apiMock = {
      login: vi.fn()
    };

    routerMock = {
      navigate: vi.fn().mockResolvedValue(true)
    };

    localStorageMock = {
      getItem: vi.fn(),
      setItem: vi.fn(),
      removeItem: vi.fn(),
      clear: vi.fn(),
      length: 0,
      key: vi.fn()
    };

    vi.stubGlobal('localStorage', localStorageMock);

    TestBed.configureTestingModule({
      providers: [
        AuthState,
        { provide: AuthApi, useValue: apiMock },
        { provide: Router, useValue: routerMock },
        provideZonelessChangeDetection()
      ]
    });

    service = TestBed.inject(AuthState);
  });

  afterEach(() => {
    vi.clearAllMocks();
    vi.unstubAllGlobals();
  });

  it('debe crearse correctamente', () => {
    expect(service).toBeTruthy();
    expect(service.isActive()).toBe(false);
    expect(service.token()).toBeNull();
  });

  describe('login()', () => {
    it('debe actualizar el estado y guardar token al recibir respuesta exitosa', () => {
      const request: AuthRequest = { userName: '123', password: 'secret' };
      apiMock.login.mockReturnValue(of(MOCK_AUTH_RESPONSE));

      const setItemSpy = vi.spyOn(localStorage, 'setItem');

      service.login(request);

      expect(apiMock.login).toHaveBeenCalledWith(request);

      expect(service.token()).toBe('fake-jwt-token');

      expect(service.isActive()).toBe(true);

      expect(setItemSpy).toHaveBeenCalledWith('token', 'fake-jwt-token');
    });
  });

  describe('logout()', () => {
    it('debe limpiar el estado, localStorage y navegar al login', async () => {
      localStorage.setItem('token', 'old-token');
      apiMock.login.mockReturnValue(of(MOCK_AUTH_RESPONSE));
      service.login({ userName: 'a', password: 'b' });

      expect(service.token()).toBe('fake-jwt-token');

      const removeItemSpy = vi.spyOn(localStorage, 'removeItem');

      await service.logout();

      expect(service.token()).toBeNull();
      expect(service.isActive()).toBe(false);
      expect(removeItemSpy).toHaveBeenCalledWith('token');
      expect(routerMock.navigate).toHaveBeenCalledWith(['/login']);
    });
  });
});
