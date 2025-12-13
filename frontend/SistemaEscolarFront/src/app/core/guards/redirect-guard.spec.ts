import { TestBed } from '@angular/core/testing';
import { Router } from '@angular/router';
import { TipoUsuario } from '@app/core/enums/tipo-usuario.enum';
import {provideZonelessChangeDetection, signal} from '@angular/core';
import { redirectGuard } from './redirect-guard';
import { describe, it, expect, beforeEach, vi } from 'vitest';
import {AuthState} from '@app/core/services/auth';

describe('RedirectGuard', () => {
  let routerMock: any;
  const mockCurrentUser = signal<{ tipoUsuario: TipoUsuario } | null>(null);

  const authStateMock = {
    currentUser: mockCurrentUser.asReadonly()
  };

  const executeGuard = () => TestBed.runInInjectionContext(() => redirectGuard(null as any, null as any));

  beforeEach(() => {
    routerMock = {
      createUrlTree: vi.fn().mockReturnValue('MOCK_URL_TREE')
    };

    TestBed.configureTestingModule({
      providers: [
        { provide: AuthState, useValue: authStateMock },
        { provide: Router, useValue: routerMock },
        provideZonelessChangeDetection()
      ]
    });
  });

  it('debe redirigir a /alumno si el usuario es ALUMNO', () => {
    mockCurrentUser.set({ tipoUsuario: TipoUsuario.alumno });

    executeGuard();

    expect(routerMock.createUrlTree).toHaveBeenCalledWith(['/alumno']);
  });

  it('debe redirigir a /gestion si el usuario es GESTIÓN', () => {
    mockCurrentUser.set({ tipoUsuario: TipoUsuario.gestion });

    executeGuard();

    expect(routerMock.createUrlTree).toHaveBeenCalledWith(['/gestion']);
  });

  it('debe redirigir a /docente si el usuario es DOCENTE', () => {
    mockCurrentUser.set({ tipoUsuario: TipoUsuario.docente });

    executeGuard();

    expect(routerMock.createUrlTree).toHaveBeenCalledWith(['/docente']);
  })

  it('debe redirigir a /login si no hay usuario', () => {
    mockCurrentUser.set(null);

    executeGuard();

    expect(routerMock.createUrlTree).toHaveBeenCalledWith(['/login']);
  });
});
