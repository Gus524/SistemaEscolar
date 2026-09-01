import {Component, inject, input} from '@angular/core';
import {DatosAlumno} from '@app/shared/ui/datos-alumno/datos-alumno';
import {HistorialAlumno} from '@app/core/models/historial-academico';
import {Location} from '@angular/common';

@Component({
  selector: 'app-header-alumno-gestion',
  imports: [
    DatosAlumno
  ],
  template: `
      <header class="header-left">
        <button type="button" class="btn-back" (click)="location.back()" aria-label="Regresar">
          <span class="material-symbols-rounded">arrow_back</span>
        </button>
      </header>
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
  location = inject(Location);
  alumno = input.required<HistorialAlumno | null>();
  title = input.required<string>();
}
