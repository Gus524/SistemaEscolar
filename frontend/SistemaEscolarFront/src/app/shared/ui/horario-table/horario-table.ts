import {Component, input, output} from '@angular/core';
import {HorarioTableModel} from '@app/core/models/horario/horario-table.model';
import {HorarioVariant} from '@app/shared/types/horario.type';
import {AlumnosGrupoRequest} from '@app/core/models/periodo-actual/alumnos-grupo.request';

@Component({
  selector: 'app-horario-table',
  imports: [],
  template: `
    <article class="table-container">
      <table class="custom-table">
        <thead class="table-head">
          <tr>
            <th class="text-center">Grupo</th>
            <th class="text-center">Clave</th>
            <th class="text-center">Materia</th>
            @if (variant() !== 'docente') {
              <th class="text-center">Docente</th>
            }
            <th class="text-center">Lun</th>
            <th class="text-center">Mar</th>
            <th class="text-center">Mié</th>
            <th class="text-center">Jue</th>
            <th class="text-center">Vie</th>
            @if (variant() === 'docente') {
              <th class="text-center">Inscritos</th>
              <th class="text-center">Detalles</th>
            }
          </tr>
        </thead>
        <tbody>
          @for (row of horario(); track $index) {
            <tr>
              <td class="fw-bold">{{ row.grupo }}</td>
              <td class="fw-muted">{{ row.clave }}</td>
              <td class="materia-cell">{{ row.materia }}</td>


              @if (variant() !== 'docente') {
                <td class="text-center">{{ row.docente || 'Sin asignar' }}</td>
              }

              <td class="text-center">{{ row.lunes }}</td>
              <td class="text-center">{{ row.martes }}</td>
              <td class="text-center">{{ row.miercoles }}</td>
              <td class="text-center">{{ row.jueves }}</td>
              <td class="text-center">{{ row.viernes }}</td>
              @if (variant() === 'docente') {
                <td class="text-center"> {{ row.inscritos || 0 }}</td>
                <td class="text-center">
                  <button type="button"
                          class="btn-icon-action"
                          (click)="viewDetailsClick(row)"
                          title="Ver detalles del grupo {{ row.clave}}">
                    <span class="material-symbols-rounded">visibility</span>
                  </button>
                </td>
              }
            </tr>
          } @empty {
            <tr>
              <td colspan="9" class="empty-state">
                <span class="material-symbols-rounded icon">calendar_today</span>
                <p>
                  {{
                    horario() === null ?
                      'Selecciona un plan de estudios para buscar horarios' :
                      'No hay horario disponible para mostrar.'
                  }}
                </p>
              </td>
            </tr>
          }
        </tbody>
      </table>
    </article>
  `,
  styles: [`
    .btn-icon-action {
      background: none;
      border: none;
      cursor: pointer;
      color: var(--color-primary-900);
      padding: 0.25rem;
      border-radius: 50%;
      transition: background-color 0.2s, transform 0.2s;
      display: inline-flex;
      align-items: center;
      justify-content: center;

      &:hover {
        background-color: rgba(0, 0, 0, 0.05);
        transform: scale(1.1);
      }

      &:active {
        transform: scale(0.95);
      }

      .material-symbols-rounded {
        font-size: 1.25rem;
      }
    }
  `]
})
export class HorarioTable {
  horario = input<HorarioTableModel[] | null>(null);
  variant = input.required<HorarioVariant>();
  viewDetails = output<AlumnosGrupoRequest>();

  viewDetailsClick = (row: HorarioTableModel) =>
    this.viewDetails.emit({
      grupo: row.grupo,
      clave: row.clave
    });
}
