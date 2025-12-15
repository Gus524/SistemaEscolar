import {Component, inject} from '@angular/core';
import {AlumnoInicio} from '@app/features/alumno/inicio/models/alumno-inicio.model';
import {InicioState} from '@app/core/services/inicio/inicio-state';
import {AuthState} from '@app/core/services/auth';
import {HomeCard} from '@app/shared/ui/home-card/home-card';

@Component({
  selector: 'app-alumno-inicio-page',
  imports: [
    HomeCard
  ],
  template: `
    @defer (when data() !== null) {
      <app-home-card [instituto]="data()!.institucion">
        <p class="details-text">
          <strong>Nombre:</strong>
          <br>
          {{ data()!.nombre }}
        </p>
        <p class="details-text">
          <strong>Carrera:</strong>
          <br>
          {{ data()!.carrera }}
        </p>
      </app-home-card>
    }
  `
})
export class AlumnoInicioPage {
  private inicioState = inject(InicioState);
  protected data = this.inicioState.as<AlumnoInicio>();
}
