import {Component, effect, inject, input} from '@angular/core';
import {KardexFacade} from '@app/core/services/historial-academico';
import {HeaderAlumnoGestion} from '@app/features/gestion/shared/ui/header-alumno-gestion/header-alumno-gestion';
import {KardexTable} from '@app/shared/ui/kardex-table/kardex-table';

@Component({
  selector: 'app-kardex-alumno',
  imports: [
    HeaderAlumnoGestion,
    KardexTable
  ],
  providers: [KardexFacade],
  template: `
    <app-header-alumno-gestion
      [alumno]="alumno.historialDetalle()?.historialAlumno!"
      [title]="'Historial alumno'"
    />

    @if (alumno.historialDetalle(); as data) {
      <app-kardex-table [historial]="data"/>
    }
  `
})
export class KardexAlumno {
  protected alumno = inject(KardexFacade);
  boleta = input.required<number>();

  constructor() {
    effect(() => {
      const boleta = this.boleta();

      if (boleta) {
        this.alumno.getHistorialDetalle(boleta);
      }
    });
  }
}
