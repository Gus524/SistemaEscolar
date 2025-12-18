import { Component } from '@angular/core';
import {CurrentAlumnoHeader} from '@app/features/alumno/shared/current-alumno-header/current-alumno-header';
import {CalificacionesTable} from '@app/shared/ui/calificaciones-table/calificaciones-table';

@Component({
  selector: 'app-mis-calificaciones-page',
  imports: [
    CurrentAlumnoHeader,
    CalificacionesTable
  ],
  template: `
    <app-current-alumno-header />
    <app-calificaciones-table />
  `
})
export class MisCalificacionesPage {}
