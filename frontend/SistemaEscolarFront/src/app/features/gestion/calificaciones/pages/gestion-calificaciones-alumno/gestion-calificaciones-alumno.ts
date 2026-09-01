import {Component, effect, inject, input} from '@angular/core';
import {CalificacionesAlumnoFacade} from '@app/core/services/calificaciones';
import {HistorialAlumnoFacade} from '@app/features/gestion/shared/services/historial-alumno-facade';
import {DatosAlumno} from '@app/shared/ui/datos-alumno/datos-alumno';
import {
  GestionDatosAlumno
} from '@app/features/gestion/datos-personales/pages/gestion-datos-alumno/gestion-datos-alumno';
import {CalificacionesTable} from '@app/shared/ui/calificaciones-table/calificaciones-table';
import {HeaderAlumnoGestion} from '@app/features/gestion/shared/ui/header-alumno-gestion/header-alumno-gestion';

@Component({
  selector: 'app-gestion-calificaciones-alumno',
  imports: [
    CalificacionesTable,
    HeaderAlumnoGestion
  ],
  providers: [CalificacionesAlumnoFacade],
  template: `
    @if (alumno.alumno(); as data) {
      <app-header-alumno-gestion [alumno]="data" [title]="'Calificaciones alumno'" />
    }

    @if (facade.calificaciones(); as data) {
      <app-calificaciones-table [calificaciones]="data" />
    }
  `
})
export class GestionCalificacionesAlumno {
  facade = inject(CalificacionesAlumnoFacade);
  alumno = inject(HistorialAlumnoFacade);
  boleta = input.required<number>();
  constructor() {
    effect(() => {
      const boleta = this.boleta();

      if (boleta) {
        this.alumno.getHistorial(boleta);
      }
    });

    effect(() => {
      const plan = this.alumno.alumno()?.idPlan;

      if (plan) {
        this.facade.getCalificaciones(this.boleta(), plan);
      }
    });
  }
}
