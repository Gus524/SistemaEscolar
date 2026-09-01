import {Component, inject} from '@angular/core';
import {CurrentAlumnoHeader} from '@app/features/alumno/shared/current-alumno-header/current-alumno-header';
import {CalificacionesTable} from '@app/shared/ui/calificaciones-table/calificaciones-table';
import {CalificacionesAlumnoFacade} from '@app/core/services/calificaciones';

@Component({
  selector: 'app-mis-calificaciones-page',
  imports: [
    CurrentAlumnoHeader,
    CalificacionesTable
  ],
  providers: [CalificacionesAlumnoFacade],
  template: `
    <app-current-alumno-header />
    @if (facade.calificaciones(); as data) {
      <app-calificaciones-table [calificaciones]="data"/>
    }
  `
})
export class MisCalificacionesPage {
  facade = inject(CalificacionesAlumnoFacade);

  constructor() {
    this.facade.getCalificaciones();
  }
}
