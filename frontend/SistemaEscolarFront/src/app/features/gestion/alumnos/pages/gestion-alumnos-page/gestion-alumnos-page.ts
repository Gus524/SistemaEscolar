import {Component, effect, inject, signal} from '@angular/core';
import {HistorialAcademicoApi} from '@app/core/services/historial-academico';
import {FormControl, ReactiveFormsModule, Validators} from '@angular/forms';
import {AsyncState} from '@app/core/utils/async-state.util';
import {HistorialAlumnoFacade} from '@app/features/gestion/shared/services/historial-alumno-facade';
import {HistorialAlumno} from '@app/core/models/historial-academico';
import {RouterLink} from '@angular/router';
import {Loader} from '@app/shared/ui/loader/loader';

@Component({
  selector: 'app-gestion-alumnos-page',
  imports: [
    RouterLink,
    Loader,
    ReactiveFormsModule
  ],
  template: `
    <main class="search-container">
      <h1>Gestión de alumnos</h1>

      <section class="search-bar-section">
        <input
          [formControl]="searchControl"
          type="text"
          class="search-input"
          placeholder="Ingresa la boleta del alumno..."
          (keyup.enter)="buscar()"
        >
        <button class="btn-search" (click)="buscar()" [disabled]="searchControl.invalid || asyncState.loading()">
          <span class="material-symbols-rounded">search</span>
        </button>
      </section>

      @if (asyncState.loading()) {
        <app-loader />
      }

      @if (!facade.error() && alumnoEncontrado(); as alumno) {
        <div class="result-dashboard">

          <article class="user-summary">
            <div>
              <h2>{{ alumno.nombre }}</h2> <p>Boleta: {{ alumno.noBoleta }} | {{ alumno.carrera }}</p>
            </div>
            <button class="btn-clear" (click)="limpiar()">Nueva búsqueda</button>
          </article>

          <section class="actions-grid">

            <a [routerLink]="['/gestion/historial-academico/historial', alumno.noBoleta]" class="action-card">
              <span class="material-symbols-rounded icon">history_edu</span>
              <span class="label">Historial Académico</span>
            </a>

            <a [routerLink]="['/gestion/historial-academico/estado-general', alumno.noBoleta]" class="action-card">
              <span class="material-symbols-rounded icon">analytics</span>
              <span class="label">Estado General</span>
            </a>

            <a [routerLink]="['/gestion/horario/alumno', alumno.noBoleta]" class="action-card">
              <span class="material-symbols-rounded icon">calendar_month</span>
              <span class="label">Horario de Clases</span>
            </a>

            <a [routerLink]="['/gestion/alumno/calificaciones', alumno.noBoleta]" class="action-card">
              <span class="material-symbols-rounded icon">grade</span>
              <span class="label">Calificaciones</span>
            </a>

            <a [routerLink]="['/gestion/alumno/datos-personales', alumno.noBoleta]" class="action-card">
              <span class="material-symbols-rounded icon">person</span>
              <span class="label">Datos Personales</span>
            </a>

          </section>
        </div>
      } @else if (facade.error()) {
        <p class="text-center text-muted">No se encontró ningún alumno con esa boleta.</p>
      }
    </main>
  `,
  styleUrl: './gestion-alumnos-page.scss'
})
export class GestionAlumnosPage {
  protected facade = inject(HistorialAlumnoFacade);

  searchControl = new FormControl('', [Validators.required, Validators.minLength(8)]);
  asyncState = new AsyncState();

  alumnoEncontrado = signal<HistorialAlumno | null>(null);
  hasSearched = signal(false);

  constructor() {
    effect(() => {
      const alumno = this.facade.alumno();
      this.hasSearched.set(true);

      if (alumno) {
        this.alumnoEncontrado.set(alumno);
      }
    });
  }
  buscar() {
    if (this.searchControl.invalid) return;

    const boleta = this.searchControl.value!;
    this.facade.getHistorial(Number(boleta));
    this.hasSearched.set(false);
  }

  limpiar() {
    this.searchControl.reset();
    this.alumnoEncontrado.set(null);
    this.hasSearched.set(false);
  }
}
