import {Component, effect, inject, signal} from '@angular/core';
import {DatosPersonalesDocenteFacade} from '@app/core/services/datos-personales/datos-personales-docente-facade';
import {FormControl, ReactiveFormsModule, Validators} from '@angular/forms';
import {AsyncState} from '@app/core/utils/async-state.util';
import {DatosDocente} from '@app/shared/ui/datos-docente/datos-docente';
import {DatosPersonalesDocente} from '@app/core/models/datos-personales/datos-docente.model';
import {Loader} from '@app/shared/ui/loader/loader';
import {RouterLink} from '@angular/router';

@Component({
  selector: 'app-gestion-docentes-page',
  imports: [
    ReactiveFormsModule,
    Loader,
    RouterLink
  ],
  template: `
    <main class="search-container">
      <h1 class="mb-4">Gestión de Docentes</h1>

      <section class="search-bar-section">
        <input
          [formControl]="searchControl"
          type="text"
          class="search-input"
          placeholder="Ingresa el RFC del docente..."
          style="text-transform: uppercase"
          (keyup.enter)="buscar()"
        >
        <button class="btn-search" (click)="buscar()" [disabled]="searchControl.invalid || asyncState.loading()">
          <span class="material-symbols-rounded">search</span>
        </button>
      </section>

      @if (asyncState.loading()) {
        <app-loader />
      }

      @if (docenteEncontrado(); as docente) {
        <div class="result-dashboard">

          <article class="user-summary">
            <div>
              <h2>{{ docente.nombre }}</h2>
              <p>RFC: {{ docente.rfc }}</p>
            </div>
            <button class="btn-clear" (click)="limpiar()">Nueva búsqueda</button>
          </article>

          <section class="actions-grid">

            <a [routerLink]="['/gestion/horario/docente', docente.rfc]" class="action-card">
              <span class="material-symbols-rounded icon">calendar_today</span>
              <span class="label">Horario Actual</span>
            </a>

            <a [routerLink]="['/gestion/docente/datos-personales', docente.rfc]" class="action-card">
              <span class="material-symbols-rounded icon">badge</span>
              <span class="label">Datos Personales</span>
            </a>

            <a class="action-card disabled" style="opacity: 0.5; cursor: not-allowed;">
              <span class="material-symbols-rounded icon">groups</span>
              <span class="label">Grupos (Próximamente)</span>
            </a>

          </section>
        </div>
      } @else if (hasSearched()) {
        <p class="text-center text-muted">No se encontró ningún docente con ese RFC.</p>
      }
    </main>
  `,
  styleUrl: './gestion-docentes-page.scss'
})
export class GestionDocentesPage {
  private facade = inject(DatosPersonalesDocenteFacade);

  searchControl = new FormControl('', [Validators.required, Validators.minLength(4)]);
  asyncState = new AsyncState();

  docenteEncontrado = signal<DatosPersonalesDocente | null>(null);
  hasSearched = signal(false);

  constructor() {
    effect(() => {
      const docente = this.facade.datos();

      if (docente) {
        this.docenteEncontrado.set(docente);
      }
    });
  }
  buscar() {
    if (this.searchControl.invalid) return;

    const rfc = this.searchControl.value!.toUpperCase();
    this.hasSearched.set(false);

    this.facade.getDatosDocente(rfc);
  }

  limpiar() {
    this.searchControl.reset();
    this.docenteEncontrado.set(null);
    this.hasSearched.set(false);
  }
}
