import {Component, inject} from '@angular/core';
import {AlumnoHorarioFacade} from '@app/core/services/horario';
import {HorarioTable} from '@app/shared/ui/horario-table/horario-table';
import {CurrentAlumnoHeader} from '@app/features/alumno/shared/current-alumno-header/current-alumno-header';

@Component({
  selector: 'app-alumno-horario-page',
  imports: [
    HorarioTable,
    CurrentAlumnoHeader
  ],
  template: `
    <app-current-alumno-header />

    @defer (when facade.horario() !== null) {
      <app-horario-table [horario]="facade.horario()!!" [variant]="'alumno'" />
    }
  `,
  providers: [
    AlumnoHorarioFacade
  ]
})
export class AlumnoHorarioPage {
  protected facade = inject(AlumnoHorarioFacade);

  constructor() {
    this.facade.getHorario();
  }
}
