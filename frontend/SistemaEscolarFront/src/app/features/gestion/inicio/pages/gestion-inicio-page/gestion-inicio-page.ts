import {Component, inject} from '@angular/core';
import {HomeCard} from '@app/shared/ui/home-card/home-card';
import {InicioState} from '@app/core/services/inicio/inicio-state';

@Component({
  selector: 'app-gestion-inicio-page',
  imports: [
    HomeCard
  ],
  template: `
    @defer (when data() !== null) {
      <app-home-card [instituto]="data()!.institucion">
        <p class="details-text">
          <strong>Usuario:</strong>
          Gestion Escolar
        </p>
      </app-home-card>
    }
  `
})
export class GestionInicioPage {
  private inicioState = inject(InicioState);
  protected data = this.inicioState.rawData;
}
