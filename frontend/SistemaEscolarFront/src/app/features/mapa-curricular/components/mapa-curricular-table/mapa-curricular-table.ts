import {Component, inject} from '@angular/core';
import {MapaCurricularState} from '@app/features/mapa-curricular/services/mapa-curricular-state';

@Component({
  selector: 'app-mapa-curricular-table',
  imports: [],
  template: `
    <article class="table-container">
      <table class="custom-table">
        <thead>
        <tr>
          <th class="text-center">Semestre</th>
          <th>Clave</th>
          <th>Materia</th>
          <th>Tipo</th>
          <th class="text-center">H. Teoria</th>
          <th class="text-center">H. Practica</th>
          <th class="text-center">Créditos</th>
        </tr>
        </thead>
        <tbody>
          @for (m of state.mapa(); track m.clave) {
            <tr>
              <td class="text-center fw-bold">{{ m.semestre }}</td>
              <td class="text-muted small">{{ m.clave }}</td>
              <td class="materia-cell">{{ m.nombreMateria }}</td>
              <td>{{ m.tipoMateria }}</td>
              <td class="text-center">{{ m.horasTeoria }}</td>
              <td class="text-center">{{ m.horasPractica }}</td>
              <td class="text-center fw-bold">{{ m.creditos }}</td>
            </tr>
          } @empty {
            <tr>
              <td colspan="7" class="empty-state">
                <span class="material-symbols-rounded icon">calendar_today</span>
                <p>
                  {{
                    state.mapa() === null
                      ? 'Selecciona un plan de estudios para ver el mapa.'
                      : 'No se encontraron materias para este plan.'
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
export class MapaCurricularTable {
  protected state = inject(MapaCurricularState);
}
