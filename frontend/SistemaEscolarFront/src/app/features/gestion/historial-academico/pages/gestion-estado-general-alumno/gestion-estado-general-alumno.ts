import {Component, effect, inject, input} from '@angular/core';
import {EstadoGeneralFacade} from '@app/core/services/historial-academico';
import {HistorialAlumnoFacade} from '@app/features/gestion/shared/services/historial-alumno-facade';
import {HeaderAlumnoGestion} from '@app/features/gestion/shared/ui/header-alumno-gestion/header-alumno-gestion';
import {EstadoGeneralCards} from '@app/shared/ui/estado-general-cards/estado-general-cards';

@Component({
  selector: 'app-gestion-estado-general-alumno',
  imports: [
    HeaderAlumnoGestion,
    EstadoGeneralCards
  ],
  providers: [HistorialAlumnoFacade, EstadoGeneralFacade],
  template: `
    <app-header-alumno-gestion
      [title]="'Estado general'"
      [alumno]="alumno.alumno()"
    />

    @if (facade.estadoGeneral(); as data){
      <app-estado-general-cards [materias]="data" [variante]="'GESTON'"/>
    }
  `
})
export class GestionEstadoGeneralAlumno {
  protected facade = inject(EstadoGeneralFacade);
  protected alumno = inject(HistorialAlumnoFacade);
  boleta = input.required<number>();

  constructor() {
    effect(() => {
      const boleta = this.boleta();

      if (boleta) {
        this.alumno.getHistorial(boleta);
      }
    });

    effect(() => {
      const datosAlumno = this.alumno.alumno();
      if (datosAlumno && this.boleta()) {
        this.facade.getEstado(this.boleta()!, datosAlumno.idPlan);
      }
    });
  }
}
