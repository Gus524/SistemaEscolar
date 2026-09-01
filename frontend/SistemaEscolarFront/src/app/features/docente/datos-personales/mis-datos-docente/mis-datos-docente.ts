import {Component, inject} from '@angular/core';
import {DatosPersonalesAlumnoFacade} from '@app/core/services/datos-personales';
import {DatosPersonalesDocenteFacade} from '@app/core/services/datos-personales/datos-personales-docente-facade';
import {DatosPersonales} from '@app/shared/ui/datos-personales/datos-personales';

@Component({
  selector: 'app-mis-datos-docente',
  imports: [
    DatosPersonales
  ],
  providers: [DatosPersonalesDocenteFacade],
  template: `
    @if (facade.datos(); as data) {
      <app-datos-personales  [data]="data" role="DOCENTE" />
    }
  `
})
export class MisDatosDocente {
  protected facade = inject(DatosPersonalesDocenteFacade);

  constructor() {
    this.facade.getDatosDocente();
  }
}
