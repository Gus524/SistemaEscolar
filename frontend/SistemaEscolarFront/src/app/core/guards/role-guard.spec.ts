import { TestBed } from '@angular/core/testing';
import { Router, Route, UrlSegment } from '@angular/router';
import { roleGuard } from './role-guard';
import { TipoUsuario } from '@app/core/enums/tipo-usuario.enum';
import {provideZonelessChangeDetection, signal} from '@angular/core';
import { describe, it, expect, beforeEach, vi } from 'vitest';
import {AuthState} from '@app/core/services/auth';

describe('RoleGuard', () => {
  let routerMock: any;

  const mockCurrentUser = signal<{ tipoUsuario: TipoUsuario } | null>(null);

  const authStateMock = {
    currentUser: mockCurrentUser.asReadonly()
  };

  const executeGuard = (rolesPermitidos: TipoUsuario[]) =>
    TestBed.runInInjectionContext(() => roleGuard(rolesPermitidos)({} as Route, [] as UrlSegment[]));

  beforeEach(() => {
    routerMock = {
      createUrlTree: vi.fn().mockReturnValue('REDIRECT_URL_TREE')
    };

    TestBed.configureTestingModule({
      providers: [
        { provide: AuthState, useValue: authStateMock },
        { provide: Router, useValue: routerMock },
        provideZonelessChangeDetection()
      ]
    });
  });

  it('debe permitir el acceso si el usuario tiene el rol correcto', () => {
    mockCurrentUser.set({ tipoUsuario: TipoUsuario.alumno });

    const result = executeGuard([TipoUsuario.alumno]);

    expect(result).toBe(true);
  });

  it('debe permitir el acceso si el usuario tiene uno de varios roles permitidos', () => {
    mockCurrentUser.set({ tipoUsuario: TipoUsuario.docente });

    const result = executeGuard([TipoUsuario.alumno, TipoUsuario.docente]);

    expect(result).toBe(true);
  });

  it('debe BLOQUEAR (redirigir) si el usuario tiene un rol incorrecto', () => {
    mockCurrentUser.set({ tipoUsuario: TipoUsuario.alumno });

    const result = executeGuard([TipoUsuario.gestion]);

    expect(result).toBe('REDIRECT_URL_TREE');
    expect(routerMock.createUrlTree).toHaveBeenCalledWith(['/login']);
  });

  it('debe redirigir al login si no hay usuario logueado', () => {
    mockCurrentUser.set(null);

    const result = executeGuard([TipoUsuario.alumno]);

    expect(result).toBe('REDIRECT_URL_TREE');
    expect(routerMock.createUrlTree).toHaveBeenCalledWith(['/login']);
  });
});
