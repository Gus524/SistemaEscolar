import {Component, input} from '@angular/core';
import {HorarioTableModel} from '@app/core/models/horario/horario-table.model';
import {HorarioVariant} from '@app/shared/types/horario.type';

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
            @if (variant() === 'docente') {
              <th class="text-center">Inscritos</th>
            }
            @if (variant() !== 'docente') {
              <th class="text-center">Docente</th>
            }
            <th class="text-center">Lun</th>
            <th class="text-center">Mar</th>
            <th class="text-center">Mié</th>
            <th class="text-center">Jue</th>
            <th class="text-center">Vie</th>
          </tr>
        </thead>
        <tbody>
          @for (row of horario(); track $index) {
            <tr>
              <td class="fw-bold">{{ row.grupo }}</td>
              <td class="fw-muted">{{ row.clave }}</td>
              <td class="materia-cell">{{ row.materia }}</td>

              @if (variant() === 'docente') {
                <td class="text-center"> {{ row.inscritos || 0 }}</td>
              }

              @if (variant() !== 'docente') {
                <td class="text-center">{{ row.docente || 'Sin asignar' }}</td>
              }

              <td class="text-center">{{ row.lunes }}</td>
              <td class="text-center">{{ row.martes }}</td>
              <td class="text-center">{{ row.miercoles }}</td>
              <td class="text-center">{{ row.jueves }}</td>
              <td class="text-center">{{ row.viernes }}</td>
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
  `
})
export class HorarioTable {
  horario = input<HorarioTableModel[] | null>(null);
  variant = input.required<HorarioVariant>();
}
