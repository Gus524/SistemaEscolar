import {Component, inject} from '@angular/core';
import {NgOptimizedImage} from '@angular/common';
import {FormControl, FormsModule, NonNullableFormBuilder, ReactiveFormsModule, Validators} from '@angular/forms';
import {AuthState} from '@app/core/services/auth';
interface LoginForm {
  userName: FormControl<string>;
  password: FormControl<string>;
}
@Component({
  selector: 'app-login',
  imports: [
    NgOptimizedImage,
    FormsModule,
    ReactiveFormsModule
  ],
  template: `
    <main class="login-layout">

      <aside class="brand-panel">
        <figure class="logo-container">
          <img
            ngSrc="/assets/img/logo/logo_p.png"
            alt="Logotipo School Shield"
            width="600"
            height="600"
          >
        </figure>
        <h1 class="brand-title">Bienvenido a<br>School Shield</h1>
      </aside>

      <section class="form-panel">
        <header class="form-header">
          <h2 class="form-title">Inicio de Sesión</h2>
          <p class="form-subtitle">Ingresa tus credenciales institucionales</p>
        </header>

        <form [formGroup]="loginForm" class="login-form" (ngSubmit)="onSubmit()">

          <label class="form-control">
            <span class="label-text">Usuario</span>
            <input
              type="text"
              formControlName="userName"
              placeholder="Usuario"
              autocomplete="username"
              [class.has-error]="isFieldInvalid('userName')"
            >
          </label>

          <label class="form-control">
            <span class="label-text">Contraseña</span>
            <input
              type="password"
              formControlName="password"
              placeholder="••••••••"
              autocomplete="current-password"
              [class.has-error]="isFieldInvalid('password')"
            >
          </label>

          @if (auth.error()) {
            <p class="error-banner" role="alert">
              <span class="material-symbols-rounded">error</span>
              {{ auth.error() }}
            </p>
          }

          <button type="submit" class="btn-submit" [disabled]="loginForm.invalid || auth.loading()">
            @if (auth.loading()) {
              Validando...
            } @else {
              Iniciar Sesión
            }
          </button>
        </form>
      </section>

    </main>
  `,
  styleUrl: './login.scss'
})
export class Login {
  protected auth = inject(AuthState);
  protected fb = inject(NonNullableFormBuilder);
  protected loginForm = this.fb.group<LoginForm>({
    userName: this.fb.control('', Validators.required),
    password: this.fb.control('', Validators.required),
  });

  isFieldInvalid(field: string): boolean {
    const control = this.loginForm.get(field);
    return !!(control?.invalid && (control?.dirty || control?.touched));
  }
  onSubmit() {
    if (this.loginForm.invalid) {
      this.loginForm.markAllAsTouched();
    } else {
      this.auth.login(this.loginForm.getRawValue());
    }
  }
}
