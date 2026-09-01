import {Component, effect, inject, input} from '@angular/core';
import {DatosPersonalesAlumnoFacade} from '@app/core/services/datos-personales';
import {DatosPersonales} from '@app/shared/ui/datos-personales/datos-personales';

@Component({
  selector: 'app-gestion-datos-alumno',
  imports: [
    DatosPersonales
  ],
  providers: [DatosPersonalesAlumnoFacade],
  template: `
    @if (facade.datos(); as data) {
      <app-datos-personales [data]="data" role="ALUMNO" />
    }
  `
})
export class GestionDatosAlumno {
  protected facade = inject(DatosPersonalesAlumnoFacade);

  boleta = input.required<number>();

  constructor() {
    effect(() => {
      const boleta = this.boleta();

      if (boleta) {
        this.facade.getDatosAlumno(boleta);
      }
    });
  }
}
