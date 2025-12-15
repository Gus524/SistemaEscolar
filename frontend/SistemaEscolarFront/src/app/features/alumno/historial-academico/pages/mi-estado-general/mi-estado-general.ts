import {Component, effect, inject} from '@angular/core';
import {EstadoGeneralFacade} from '@app/core/services/historial-academico';
import {InicioState} from '@app/core/services/inicio';
import {AlumnoInicio} from '@app/features/alumno/inicio/models/alumno-inicio.model';
import {AuthState} from '@app/core/services/auth';
import {CurrentAlumnoHeader} from '@app/features/alumno/shared/current-alumno-header/current-alumno-header';
import {EstadoGeneralCards} from '@app/shared/ui/estado-general-cards/estado-general-cards';

@Component({
  selector: 'app-mi-estado-general',
  imports: [
    CurrentAlumnoHeader,
    EstadoGeneralCards
  ],
  providers: [EstadoGeneralFacade],
  template: `
    <app-current-alumno-header />
    @if (facade.estadoGeneral(); as data){
      <app-estado-general-cards [materias]="data" />
    }
  `
})
export class MiEstadoGeneral {
  private auth = inject(AuthState);
  private inicio = inject(InicioState);
  protected facade = inject(EstadoGeneralFacade);
  alumnoInicio = this.inicio.as<AlumnoInicio>();

  constructor() {
    effect(() => {
      const plan = this.alumnoInicio()?.idPlan;
      const boleta = this.auth.currentUser()?.usuario;

      if (plan && boleta) {
        this.facade.getEstado(Number(boleta), plan);
      }
    });
  }
}
