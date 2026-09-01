import {Component, effect, inject, input} from '@angular/core';
import {DocenteHorarioFacade} from '@app/core/services/horario';
import {DatosPersonalesDocenteFacade} from '@app/core/services/datos-personales/datos-personales-docente-facade';
import {DatosDocente} from '@app/shared/ui/datos-docente/datos-docente';
import {HorarioTable} from '@app/shared/ui/horario-table/horario-table';
import {AlumnosGrupoRequest} from '@app/core/models/periodo-actual/alumnos-grupo.request';
import {Router} from '@angular/router';
import {Location} from '@angular/common';

@Component({
  selector: 'app-gestion-docente-horario',
  imports: [
    DatosDocente,
    HorarioTable
  ],
  providers: [DocenteHorarioFacade, DatosPersonalesDocenteFacade],
  template: `
      <header class="header-left">
        <button type="button" class="btn-back" (click)="location.back()" aria-label="Regresar">
          <span class="material-symbols-rounded">arrow_back</span>
        </button>
      </header>
    @if (docente.datos(); as data) {
      <app-datos-docente
        [nombre]="data.nombre!" [academia]="data.academia!" [titulo]="'Horario'"
      />
    }
    @if (horario.horario(); as data) {
      <app-horario-table [horario]="data" variant="docente" (viewDetails)="goToDetails($event)" />
    }
  `
})
export class GestionDocenteHorario {
  protected location = inject(Location);
  private router = inject(Router);
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

  async goToDetails(data: AlumnosGrupoRequest) {
    await this.router.navigate(['/common/grupo-detalle', data.grupo, data.clave]);
  }
}
