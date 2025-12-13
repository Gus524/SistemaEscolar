import {Component, inject} from '@angular/core';
import {InicioState} from '@app/core/services/inicio/inicio-state';
import {DocenteInicio} from '@app/features/docente/inicio/models/docente-inicio.model';
import {HomeCard} from '@app/shared/ui/home-card/home-card';

@Component({
  selector: 'app-docente-inicio-page',
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
          <strong>Academia:</strong>
          <br>
          {{ data()!.academia }}
        </p>
      </app-home-card>
    }
  `
})
export class DocenteInicioPage {
  private inicioState = inject(InicioState);
  protected data = this.inicioState.as<DocenteInicio>();
}
