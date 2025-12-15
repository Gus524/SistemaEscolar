import { TestBed } from '@angular/core/testing';
import { Route, UrlSegment } from '@angular/router';
import { roleGuard } from './role-guard';
import { TipoUsuario } from '@app/core/enums/tipo-usuario.enum';
import { provideZonelessChangeDetection, signal } from '@angular/core';
import { describe, it, expect, beforeEach, vi } from 'vitest';
import { AuthState } from '@app/core/services/auth';

describe('RoleGuard', () => {
  const mockCurrentUser = signal<{ tipoUsuario: TipoUsuario } | null>(null);
  const mockIsActive = signal(false);

  const authStateMock = {
    currentUser: mockCurrentUser.asReadonly(),
    isActive: mockIsActive, // El guard ahora verifica isActive() también
    accessDenied: vi.fn().mockReturnValue('LOGIN_REDIRECT'),
    forbidden: vi.fn().mockReturnValue('FORBIDDEN_REDIRECT')
  };

  const executeGuard = (rolesPermitidos: TipoUsuario[]) =>
    TestBed.runInInjectionContext(() => roleGuard(rolesPermitidos)({} as Route, [] as UrlSegment[]));

  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        { provide: AuthState, useValue: authStateMock },
        provideZonelessChangeDetection()
      ]
    });
    vi.clearAllMocks();
  });

  it('debe permitir el acceso si el usuario tiene el rol correcto y está activo', () => {
    mockIsActive.set(true);
    mockCurrentUser.set({ tipoUsuario: TipoUsuario.alumno });

    const result = executeGuard([TipoUsuario.alumno]);

    expect(result).toBe(true);
  });

  it('debe llamar a forbidden() si el usuario tiene un rol incorrecto', () => {
    mockIsActive.set(true);
    mockCurrentUser.set({ tipoUsuario: TipoUsuario.alumno });

    const result = executeGuard([TipoUsuario.gestion]);

    expect(result).toBe('FORBIDDEN_REDIRECT');
    expect(authStateMock.forbidden).toHaveBeenCalled();
  });

  it('debe llamar a accessDenied() si no hay usuario o no está activo', () => {
    mockIsActive.set(false);
    mockCurrentUser.set(null);

    const result = executeGuard([TipoUsuario.alumno]);

    expect(result).toBe('LOGIN_REDIRECT');
    expect(authStateMock.accessDenied).toHaveBeenCalled();
  });
});
