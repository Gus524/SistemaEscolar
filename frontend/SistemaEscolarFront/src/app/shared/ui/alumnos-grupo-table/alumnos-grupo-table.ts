import {Component, input, output} from '@angular/core';
import {AlumnosGrupo} from '@app/core/models/periodo-actual/alumnos-grupo.model';

@Component({
  selector: 'app-alumnos-grupo-table',
  imports: [],
  template: `
    <header class="table-header">
      <div class="header-left">
        <button type="button" class="btn-back" (click)="goBack.emit()" aria-label="Regresar">
          <span class="material-symbols-rounded">arrow_back</span>
        </button>
        <h2>Detalle del grupo</h2>
      </div>
    </header>
    <hr>
    @if (alumnos().length > 0) {
      <article class="table-container">
        <table class="custom-table group-layout">
          <thead class="table-head">
          <tr>
            <th class="col-boleta">Boleta</th>
            <th class="col-email">Correos</th>
            <th class="col-nombre">Nombre</th>
            <th class="text-center col-calif">P1</th>
            <th class="text-center col-calif">P2</th>
            <th class="text-center col-calif">P3</th>
            <th class="text-center col-calif">Extra</th>
            <th class="text-center col-calif">Prom</th>
          </tr>
          </thead>
          <tbody>
            @for (alumno of alumnos(); track alumno.noBoleta) {
              <tr>
                <td class="fw-muted font-monospace">{{ alumno.noBoleta }}</td>

                <td>
                  <div class="email-stack">
                    <span class="text-primary">{{ alumno.emailInstitucional || '-' }}</span>
                    <span class="text-muted small">{{ alumno.emailPersonal }}</span>
                  </div>
                </td>

                <td class="materia-cell">{{ alumno.nombre }}</td>

                <td class="text-center">{{ alumno.primerParcial || '-' }}</td>
                <td class="text-center">{{ alumno.segundoParcial || '-' }}</td>
                <td class="text-center">{{ alumno.tercerParcial || '-' }}</td>
                <td class="text-center">{{ alumno.extra || '-' }}</td>

                <td class="text-center fw-bold"
                    [class.text-danger]="isReprobado(alumno.final)">
                  {{ alumno.final || '-' }}
                </td>
              </tr>
            }
          </tbody>
        </table>
      </article>
    } @else {
      <article class="empty-state">
        <span class="material-symbols-rounded icon">person_off</span>
        <p>No hay información de alumnos para mostrar en este grupo.</p>
      </article>
    }
  `,
  styles: [`
    .table-header {
      display: flex;
      align-items: center;
      margin-bottom: 0.5rem;
    }

    .header-left {
      display: flex;
      align-items: center;
      gap: 1rem;

      h2 { margin: 0; font-size: 1.5rem; }
    }

    .btn-back {
      background: none;
      border: none;
      cursor: pointer;
      padding: 0.5rem;
      border-radius: 50%;
      color: var(--color-primary-900);
      display: flex;
      align-items: center;
      justify-content: center;
      transition: background-color 0.2s;

      &:hover {
        background-color: rgba(0,0,0,0.05);
      }

      .material-symbols-rounded { font-size: 1.5rem; }
    }

    .group-layout {
      table-layout: fixed;
    }

    .col-boleta { width: 12%; }
    .col-email  { width: 25%; }
    .col-nombre { width: 28%; }
    .col-calif  { width: 7%; }

    .font-monospace {
      font-family: 'Courier New', monospace;
      letter-spacing: -0.5px;
    }

    .email-stack {
      display: flex;
      flex-direction: column;
      gap: 0.2rem;
      font-size: 0.85rem;
      overflow: hidden;

      .text-primary { color: var(--color-primary-900); font-weight: 500; }
      .small { font-size: 0.75rem; }
    }

    .text-danger { color: var(--color-danger); }
  `]
})
export class AlumnosGrupoTable {
  alumnos = input.required<AlumnosGrupo[]>();

  goBack = output<void>();
  isReprobado(val: string | number | undefined): boolean {
    if (!val || val === '') return false;
    const num = Number(val);
    return !isNaN(num) && num < 6;
  }
}
