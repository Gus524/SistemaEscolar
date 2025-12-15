import {Component, input} from '@angular/core';
import {HistorialAlumnoResponse} from '@app/core/models/historial-academico';
import {SemestreLabelPipe} from '@app/shared/pipes/semestre-label-pipe';

@Component({
  selector: 'app-kardex-table',
  imports: [
    SemestreLabelPipe
  ],
  template: `
    @if (historial(); as data) {
      <article class="datos-container datos-header">
        <hgroup class="info-row">
          <p class="datos-text">
            <strong>Plan: </strong>
            {{ historial().historialAlumno.plan }}
          </p>
          <p class="datos-text">
            <strong>Promedio: </strong>
            {{ historial().historialAlumno.promedio }}
          </p>
        </hgroup>
      </article>

      @for (semestre of data.semestreHistorial; track semestre.semestre) {
        <h3 class="section-title">{{ semestre.semestre | semestreLabel }}</h3>
        <article class="table-container">
          <table class="custom-table kardex-layout">
            <thead class="table-head">
              <tr>
                <th class="col-clave">Clave</th>
                <th class="col-materia">Materia</th>
                <th class="col-fecha">Fecha</th>
                <th class="col-periodo">Periodo</th>
                <th class="col-eval">Forma Eval.</th>
                <th class="col-calif">Calificación</th>
              </tr>
            </thead>
            <tbody>
              @for (materia of semestre.materias; track materia.clave) {
                <tr>
                  <td class="col-clave">{{ materia.clave }}</td>
                  <td class="col-materia">{{ materia.materia }}</td>
                  <td class="col-fecha">{{ materia.fechaEval }}</td>
                  <td class="col-periodo">{{ materia.descPeriodo }}</td>
                  <td class="col-eval">{{ materia.formaEval }}</td>
                  <td class="col-calif">{{ materia.calificacion }}</td>
                </tr>
              } @empty {}
            </tbody>
          </table>
        </article>
        <br>
      } @empty {
        <p class="empty-state">No se encontró historial académico</p>
      }
    }
  `,
  styles: [`
    .kardex-layout {
      table-layout: fixed;
    }

    .col-clave {
      width: 10%;
    }

    .col-materia {
      width: 40%;
    }

    .col-fecha {
      width: 15%;
    }

    .col-periodo {
      width: 15%;
    }

    .col-eval {
      width: 10%;
    }

    .col-calif {
      width: 10%;
    }
  `]
})
export class KardexTable {
  historial = input.required<HistorialAlumnoResponse>();
}
