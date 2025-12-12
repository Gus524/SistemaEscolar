import { TestBed } from '@angular/core/testing';
import { MenuState } from './menu-state';
import { AuthState } from '@app/core/services/auth/auth-state';
import { MENU_CONFIG } from '@app/core/config/menu.config';
import { TipoUsuario } from '@app/core/enums/tipo-usuario.enum';
import {provideZonelessChangeDetection, signal} from '@angular/core';
import { describe, it, expect, beforeEach } from 'vitest';

describe('MenuState Service', () => {
  let service: MenuState;

  const mockCurrentUser = signal<{ tipoUsuario: TipoUsuario } | null>(null);

  const authStateMock = {
    currentUser: mockCurrentUser.asReadonly()
  };

  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        MenuState,
        { provide: AuthState, useValue: authStateMock },
        provideZonelessChangeDetection()
      ]
    });

    service = TestBed.inject(MenuState);

    mockCurrentUser.set(null);
  });

  it('debe crearse correctamente', () => {
    expect(service).toBeTruthy();
  });

  it('debe retornar un array vacío si no hay usuario logueado', () => {
    mockCurrentUser.set(null);

    expect(service.menuItems()).toEqual([]);
  });

  it('debe retornar el menú de ALUMNO cuando el usuario es alumno', () => {
    mockCurrentUser.set({ tipoUsuario: TipoUsuario.alumno });

    const items = service.menuItems();

    expect(items).toBe(MENU_CONFIG[TipoUsuario.alumno]);
    expect(items.length).toBeGreaterThan(0);
    expect(items[0].label).toBeDefined();
  });

  it('debe retornar el menú de DOCENTE cuando el usuario es docente', () => {
    mockCurrentUser.set({ tipoUsuario: TipoUsuario.docente });

    const items = service.menuItems();

    expect(items).toBe(MENU_CONFIG[TipoUsuario.docente]);
  });

  it('debe ser reactivo: actualizar el menú si cambia el usuario', () => {
    mockCurrentUser.set({ tipoUsuario: TipoUsuario.alumno });
    expect(service.menuItems()).toBe(MENU_CONFIG[TipoUsuario.alumno]);

    mockCurrentUser.set(null);
    expect(service.menuItems()).toEqual([]);

    mockCurrentUser.set({ tipoUsuario: TipoUsuario.gestion });
    expect(service.menuItems()).toBe(MENU_CONFIG[TipoUsuario.gestion]);
  });

  it('debe retornar array vacío si el tipo de usuario no existe en la config', () => {
    const usuarioInvalido = { tipoUsuario: 999 as TipoUsuario };
    mockCurrentUser.set(usuarioInvalido);

    expect(service.menuItems()).toEqual([]);
  });
});
