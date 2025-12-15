import {Component, effect, inject, input} from '@angular/core';
import {DocenteHorarioFacade} from '@app/core/services/horario';
import {DatosPersonalesDocenteFacade} from '@app/core/services/datos-personales/datos-personales-docente-facade';
import {DatosDocente} from '@app/shared/ui/datos-docente/datos-docente';
import {HorarioTable} from '@app/shared/ui/horario-table/horario-table';

@Component({
  selector: 'app-gestion-docente-horario',
  imports: [
    DatosDocente,
    HorarioTable
  ],
  providers: [DocenteHorarioFacade, DatosPersonalesDocenteFacade],
  template: `
    @if (docente.datos(); as data) {
      <app-datos-docente
        [nombre]="data.nombre!" [academia]="data.academia!" [titulo]="'Horario'"
      />
    }
    @if (horario.horario(); as data) {
      <app-horario-table [horario]="data" variant="docente" />
    }
  `
})
export class GestionDocenteHorario {
  protected horario = inject(DocenteHorarioFacade);
  protected docente = inject(DatosPersonalesDocenteFacade);

  rfc = input.required<string>();

  constructor() {
    effect(() => {
      const rfc = this.rfc();

      if (rfc) {
        this.horario.getHorario(rfc);
        this.docente.getDatosDocente(rfc);
      }
    });
  }
}
