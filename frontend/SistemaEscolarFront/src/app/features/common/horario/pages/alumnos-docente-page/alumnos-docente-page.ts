import {Component, effect, inject, input} from '@angular/core';
import {AlumnosGrupoFacade} from '@app/core/services/periodo-actual/alumnos-grupo-facade';
import {AlumnosGrupoRequest} from '@app/core/models/periodo-actual/alumnos-grupo.request';
import {AlumnosGrupoTable} from '@app/shared/ui/alumnos-grupo-table/alumnos-grupo-table';
import {Location} from '@angular/common';

@Component({
  selector: 'app-alumnos-docente-page',
  imports: [
    AlumnosGrupoTable
  ],
  providers: [AlumnosGrupoFacade],
  template:`
    @if (facade.alumnos(); as data) {
      <app-alumnos-grupo-table [alumnos]="data" (goBack)="location.back()"/>
    }
  `
})
export class AlumnosDocentePage {
  protected facade = inject(AlumnosGrupoFacade);
  location = inject(Location);
  grupo = input.required<string>();
  clave = input.required<string>();

  constructor() {
    effect(() => {
      const g = this.grupo();
      const c = this.clave();

      if (g && c) {
        const request: AlumnosGrupoRequest = {
          grupo: g,
          clave: c
        };
        this.facade.getAlumnosGrupo(request);
      }
    });
  }
}
