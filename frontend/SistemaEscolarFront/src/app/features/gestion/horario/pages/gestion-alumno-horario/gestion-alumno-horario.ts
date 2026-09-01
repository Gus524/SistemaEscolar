import {Component, effect, inject, input} from '@angular/core';
import {AlumnoHorarioFacade} from '@app/core/services/horario';
import {HorarioTable} from '@app/shared/ui/horario-table/horario-table';
import {DatosAlumno} from '@app/shared/ui/datos-alumno/datos-alumno';
import {HistorialAlumnoFacade} from '@app/features/gestion/shared/services/historial-alumno-facade';
import {HeaderAlumnoGestion} from '@app/features/gestion/shared/ui/header-alumno-gestion/header-alumno-gestion';

@Component({
  selector: 'app-gestion-alumno-horario',
  imports: [
    HorarioTable,
    DatosAlumno,
    HeaderAlumnoGestion
  ],
  providers: [HistorialAlumnoFacade, AlumnoHorarioFacade],
  template: `
    @if (alumno.alumno(); as data) {
      <app-header-alumno-gestion [alumno]="data" [title]="'Horario'"/>
    }
    @if (facade.horario(); as data) {
      <app-horario-table [horario]="data" variant="alumno" />
    }
  `
})
export class GestionAlumnoHorario {
  protected facade = inject(AlumnoHorarioFacade);
  protected alumno = inject(HistorialAlumnoFacade);
  boleta = input.required<number>();

  constructor() {
    effect(() => {
      const boleta = this.boleta();

      if (boleta) {
        this.facade.getHorario(boleta);
        this.alumno.getHistorial(boleta);
      }
    });
  }
}
