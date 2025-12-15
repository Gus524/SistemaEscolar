import {Component, effect, inject, input} from '@angular/core';
import {AlumnoHorarioFacade} from '@app/core/services/horario';
import {HorarioTable} from '@app/shared/ui/horario-table/horario-table';
import {DatosPersonalesAlumnoFacade} from '@app/core/services/datos-personales';
import {DatosAlumno} from '@app/shared/ui/datos-alumno/datos-alumno';

@Component({
  selector: 'app-gestion-alumno-horario',
  imports: [
    HorarioTable,
    DatosAlumno
  ],
  providers: [DatosPersonalesAlumnoFacade, AlumnoHorarioFacade],
  template: `
    @if (alumno.datos(); as data) {
      <app-datos-alumno
        [nombre]="data.nombre!!"
        [boleta]="data.noBoleta.toString()"
        [titulo]="'Horario'"
      />
    }
    @if (facade.horario(); as data) {
      <app-horario-table [horario]="data" variant="alumno" />
    }
  `
})
export class GestionAlumnoHorario {
  protected facade = inject(AlumnoHorarioFacade);
  protected alumno = inject(DatosPersonalesAlumnoFacade);
  boleta = input.required<number>();

  constructor() {
    effect(() => {
      const boleta = this.boleta();

      if (boleta) {
        this.facade.getHorario(boleta);
        this.alumno.getDatosAlumno(boleta);
      }
    });
  }
}
