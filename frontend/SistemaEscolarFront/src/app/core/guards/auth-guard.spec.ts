import { TestBed } from '@angular/core/testing';
import { Route, UrlSegment } from '@angular/router';
import { authGuard } from './auth-guard';
import { provideZonelessChangeDetection, signal } from '@angular/core';
import { describe, it, expect, beforeEach, vi } from 'vitest';
import { AuthState } from '@app/core/services/auth';

describe('AuthGuard', () => {
  const isActiveSignal = signal(false);

  const authStateMock = {
    isActive: isActiveSignal,
    accessDenied: vi.fn().mockReturnValue('REDIRECT_URL_TREE_FROM_SERVICE')
  };

  const executeGuard = () =>
    TestBed.runInInjectionContext(() => authGuard({} as Route, [] as UrlSegment[]));

  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        { provide: AuthState, useValue: authStateMock },
        provideZonelessChangeDetection()
      ]
    });

    isActiveSignal.set(false);
    vi.clearAllMocks();
  });

  it('debe permitir el acceso (return true) si el usuario está activo', () => {
    isActiveSignal.set(true);

    const result = executeGuard();

    expect(result).toBe(true);
    expect(authStateMock.accessDenied).not.toHaveBeenCalled();
  });

  it('debe llamar a auth.accessDenied() si el usuario NO está activo', () => {
    isActiveSignal.set(false);

    const result = executeGuard();

    expect(result).toBe('REDIRECT_URL_TREE_FROM_SERVICE');
    expect(authStateMock.accessDenied).toHaveBeenCalled();
  });
});
