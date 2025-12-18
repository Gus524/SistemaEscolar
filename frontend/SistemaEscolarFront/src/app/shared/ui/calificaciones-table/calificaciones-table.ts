import {Component, inject} from '@angular/core';
import {CalificacionesAlumnoFacade} from '@app/core/services/calificaciones';

@Component({
  selector: 'app-calificaciones-table',
  imports: [],
  providers: [CalificacionesAlumnoFacade],
  template: `
    <article class="table-container">
      <table class="custom-table">
        <thead class="table-head">
          <tr>
            <th class="text-center">Grupo</th>
            <th class="text-center">Clave</th>
            <th class="text-center">Materia</th>
            <th class="text-center">Primer parcial</th>
            <th class="text-center">Segundo parcial</th>
            <th class="text-center">Tercer parcial</th>
            <th class="text-center">Extra</th>
            <th class="text-center">Final</th>
          </tr>
        </thead>
        <tbody>
          @for (row of facade.califaciones() ?? []; track row.clave) {
            <tr>
              <td class="fw-bold">{{ row.grupo }}</td>
              <td class="fw-muted">{{ row.clave }}</td>
              <td class="materia-cell">{{ row.materia }}</td>
              <td class="text-center">{{ row.primerParcial }}</td>
              <td class="text-center">{{ row.segundoParcial }}</td>
              <td class="text-center">{{ row.tercerParcial }}</td>
              <td class="text-center">{{ row.extra }}</td>
              <td class="text-center">{{ row.final }}</td>
            </tr>
          } @empty {
            <tr>
              <td colspan="8" class="empty-state">
                <span class="material-symbols-rounded icon">assignment_late</span>
                <p>No estas inscrito en el periodo actual</p>
              </td>
            </tr>
          }
        </tbody>
      </table>
    </article>
  `
})
export class CalificacionesTable {
  protected facade = inject(CalificacionesAlumnoFacade);

  constructor() {
    this.facade.getCalificaciones();
  }
}
