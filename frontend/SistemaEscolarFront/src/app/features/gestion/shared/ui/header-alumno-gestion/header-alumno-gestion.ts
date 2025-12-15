import {Component, input} from '@angular/core';
import {DatosAlumno} from '@app/shared/ui/datos-alumno/datos-alumno';
import {HistorialAlumno} from '@app/core/models/historial-academico';

@Component({
  selector: 'app-header-alumno-gestion',
  imports: [
    DatosAlumno
  ],
  template: `
    @if (alumno(); as data) {
      <app-datos-alumno
        [nombre]="data.nombre!!"
        [boleta]="data.noBoleta.toString()"
        [titulo]="title()"
      />
    }
  `
})
export class HeaderAlumnoGestion {
  alumno = input.required<HistorialAlumno | null>();
  title = input.required<string>();
}
