import { TestBed } from '@angular/core/testing';
import { Router, Route, UrlSegment } from '@angular/router';
import { authGuard } from './auth-guard';
import {provideZonelessChangeDetection, signal} from '@angular/core';
import { describe, it, expect, beforeEach, vi } from 'vitest';
import {AuthState} from '@app/core/services/auth';

describe('AuthGuard', () => {
  let routerMock: any;

  const isActiveSignal = signal(false);

  const authStateMock = {
    isActive: isActiveSignal
  };

  const executeGuard = () =>
    TestBed.runInInjectionContext(() => authGuard({} as Route, [] as UrlSegment[]));

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

  it('debe permitir el acceso (return true) si el usuario está activo', () => {
    isActiveSignal.set(true);

    const result = executeGuard();

    expect(result).toBe(true);
    expect(routerMock.createUrlTree).not.toHaveBeenCalled();
  });

  it('debe redirigir al login si el usuario NO está activo', () => {
    isActiveSignal.set(false);

    const result = executeGuard();

    expect(result).toBe('REDIRECT_URL_TREE');
    expect(routerMock.createUrlTree).toHaveBeenCalledWith(['/login']);
  });
});
