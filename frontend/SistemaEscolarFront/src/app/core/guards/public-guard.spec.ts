import { TestBed } from '@angular/core/testing';
import { Route, Router, UrlSegment } from '@angular/router';
import { publicGuard } from './public-guard';
import { describe, it, expect, beforeEach, vi } from 'vitest';
import { AuthState } from '@app/core/services/auth';
import { provideZonelessChangeDetection, signal } from '@angular/core';

describe('PublicGuard', () => {
  let routerMock: any;
  const mockIsActive = signal(false);

  const authStateMock = {
    isActive: mockIsActive
  };

  const executeGuard = () =>
    TestBed.runInInjectionContext(() => publicGuard({} as Route, [] as UrlSegment[]));

  beforeEach(() => {
    routerMock = {
      createUrlTree: vi.fn().mockReturnValue('HOME_REDIRECT')
    };

    TestBed.configureTestingModule({
      providers: [
        { provide: AuthState, useValue: authStateMock },
        { provide: Router, useValue: routerMock },
        provideZonelessChangeDetection()
      ]
    });
  });

  it('debe permitir acceso (true) si NO hay sesión activa', () => {
    mockIsActive.set(false);

    const result = executeGuard();

    expect(result).toBe(true);
    expect(routerMock.createUrlTree).not.toHaveBeenCalled();
  });

  it('debe redirigir al home [/] si YA existe sesión activa', () => {
    mockIsActive.set(true);

    const result = executeGuard();

    expect(result).toBe('HOME_REDIRECT');
    expect(routerMock.createUrlTree).toHaveBeenCalledWith(['/']);
  });
});
