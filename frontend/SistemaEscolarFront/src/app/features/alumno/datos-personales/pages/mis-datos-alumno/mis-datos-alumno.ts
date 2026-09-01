import {Component, inject} from '@angular/core';
import {DatosPersonalesAlumnoFacade} from '@app/core/services/datos-personales';
import {DatosPersonales} from '@app/shared/ui/datos-personales/datos-personales';

@Component({
  selector: 'app-mis-datos-alumno',
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
export class MisDatosAlumno {
  protected facade = inject(DatosPersonalesAlumnoFacade);

  constructor() {
    this.facade.getDatosAlumno();
  }
}
