import { ComponentFixture, TestBed } from '@angular/core/testing';
import { Login } from './login';
import { AuthState } from '@app/core/services/auth';
import { provideZonelessChangeDetection, signal } from '@angular/core';
import { By } from '@angular/platform-browser';
import { vi, describe, it, expect, beforeEach } from 'vitest';

describe('Login Component', () => {
  let component: Login;
  let fixture: ComponentFixture<Login>;

  const loadingSignal = signal(false);
  const errorSignal = signal<string | null>(null);

  const authStateMock = {
    login: vi.fn(),
    loading: loadingSignal.asReadonly(),
    error: errorSignal.asReadonly()
  };

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Login],
      providers: [
        provideZonelessChangeDetection(),
        { provide: AuthState, useValue: authStateMock }
      ]
    }).compileComponents();

    fixture = TestBed.createComponent(Login);
    component = fixture.componentInstance;

    loadingSignal.set(false);
    errorSignal.set(null);
    authStateMock.login.mockClear();

    fixture.detectChanges();
  });

  it('debe crearse correctamente', () => {
    expect(component).toBeTruthy();
  });

  describe('Validación de Formulario', () => {
    it('debe iniciar con el formulario inválido', () => {
      const form = (component as any).loginForm;
      expect(form.valid).toBe(false);
    });

    it('debe deshabilitar el botón de submit si el formulario es inválido', () => {
      const btn = fixture.debugElement.query(By.css('.btn-submit'));
      expect(btn.nativeElement.disabled).toBe(true);
    });

    it('NO debe llamar a auth.login() si se fuerza el submit con datos inválidos', () => {
      component.onSubmit();
      expect(authStateMock.login).not.toHaveBeenCalled();
    });

    it('debe marcar los campos como "touched" y mostrar errores visuales al intentar enviar vacío', () => {
      component.onSubmit();
      fixture.detectChanges();
      const userNameInput = fixture.debugElement.query(By.css('input[formControlName="userName"]'));
      expect(userNameInput.classes['has-error']).toBe(true);
    });
  });

  describe('Interacción Exitosa', () => {
    it('debe llamar a auth.login() con los datos correctos si el formulario es válido', () => {
      const form = (component as any).loginForm;

      form.setValue({
        userName: 'alumno123',
        password: 'passwordSeguro'
      });
      fixture.detectChanges();

      const btn = fixture.debugElement.query(By.css('.btn-submit'));
      expect(btn.nativeElement.disabled).toBe(false);

      btn.nativeElement.click();

      expect(authStateMock.login).toHaveBeenCalledWith({
        userName: 'alumno123',
        password: 'passwordSeguro'
      });
    });
  });

  describe('Reactividad de UI (Signals)', () => {
    it('debe mostrar el mensaje de error cuando auth.error() tiene valor', () => {
      errorSignal.set('Credenciales Incorrectas');
      fixture.detectChanges();

      const errorBanner = fixture.debugElement.query(By.css('.error-banner'));
      expect(errorBanner).toBeTruthy();
      expect(errorBanner.nativeElement.textContent).toContain('Credenciales Incorrectas');
    });

    it('debe mostrar estado de carga y deshabilitar botón cuando auth.loading() es true', () => {
      loadingSignal.set(true);
      fixture.detectChanges();

      const btn = fixture.debugElement.query(By.css('.btn-submit'));

      expect(btn.nativeElement.disabled).toBe(true);

      expect(btn.nativeElement.textContent).toContain('Validando...');
    });
  });
});
