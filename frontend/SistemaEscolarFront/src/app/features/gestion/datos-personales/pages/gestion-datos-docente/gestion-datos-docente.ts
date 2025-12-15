import {Component, effect, inject, input} from '@angular/core';
import {DatosPersonalesDocenteFacade} from '@app/core/services/datos-personales/datos-personales-docente-facade';
import {DatosPersonales} from '@app/shared/ui/datos-personales/datos-personales';

@Component({
  selector: 'app-gestion-datos-docente',
  imports: [
    DatosPersonales
  ],
  template: `
    @if (facade.datos(); as data){
      <app-datos-personales [data]="data" role="DOCENTE" />
    }
  `
})
export class GestionDatosDocente {
  protected facade = inject(DatosPersonalesDocenteFacade);
  rfc = input<string>();

  constructor() {
    effect(() => {
      const rfc = this.rfc();

      if (rfc) {
        this.facade.getDatosDocente(rfc);
      }
    });
  }
}
