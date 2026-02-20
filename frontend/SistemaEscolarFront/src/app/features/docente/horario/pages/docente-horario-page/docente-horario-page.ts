import {Component, inject} from '@angular/core';
import {DocenteHorarioFacade} from '@app/core/services/horario';
import {CurrentDocenteHeader} from '@app/features/docente/shared/current-docente-header/current-docente-header';
import {HorarioTable} from '@app/shared/ui/horario-table/horario-table';
import {Router} from '@angular/router';
import {AlumnosGrupoRequest} from '@app/core/models/periodo-actual/alumnos-grupo.request';

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
      <app-horario-table [horario]="facade.horario()!!" [variant]="'docente'" (viewDetails)="goToDetail($event)" />
    }
  `
})
export class DocenteHorarioPage {
  protected facade = inject(DocenteHorarioFacade);
  private router = inject(Router);

  constructor() {
    this.facade.getHorario();
  }

  async goToDetail(ruta: AlumnosGrupoRequest) {
    await this.router.navigate([`/docente/grupo-detalle`, ruta.grupo, ruta.clave]);
  }
}
