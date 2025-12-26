import {Component, inject} from '@angular/core';
import {KardexFacade} from '@app/core/services/historial-academico';
import {CurrentAlumnoHeader} from '@app/features/alumno/shared/current-alumno-header/current-alumno-header';
import {KardexTable} from '@app/shared/ui/kardex-table/kardex-table';

@Component({
  selector: 'app-mi-kardex',
  imports: [
    CurrentAlumnoHeader,
    KardexTable
  ],
  providers: [KardexFacade],
  template: `
    <app-current-alumno-header />
    @if (facade.historialDetalle(); as data) {
      <app-kardex-table [historial]="data"/>
    }
  `
})
export class MiKardex {
  protected facade = inject(KardexFacade);

  constructor() {
    this.facade.getHistorialDetalle();
  }
}
