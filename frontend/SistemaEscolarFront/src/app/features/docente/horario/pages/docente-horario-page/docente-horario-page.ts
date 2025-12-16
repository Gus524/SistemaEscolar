import {Component, inject} from '@angular/core';
import {DocenteHorarioFacade} from '@app/core/services/horario';
import {CurrentDocenteHeader} from '@app/features/docente/shared/current-docente-header/current-docente-header';
import {HorarioTable} from '@app/shared/ui/horario-table/horario-table';

@Component({
  selector: 'app-docente-horario-page',
  imports: [
    CurrentDocenteHeader,
    HorarioTable
  ],
  providers: [DocenteHorarioFacade],
  template: `
    <app-current-docente-header />

    @defer (when facade.horario() !== null) {
      <app-horario-table [horario]="facade.horario()!!" [variant]="'docente'" />
    }
  `
})
export class DocenteHorarioPage {
  protected facade = inject(DocenteHorarioFacade);

  constructor() {
    this.facade.getHorario();
  }
}
