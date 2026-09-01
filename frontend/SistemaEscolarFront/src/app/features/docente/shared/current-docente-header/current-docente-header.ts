import {Component, computed, inject} from '@angular/core';
import {InicioState} from '@app/core/services/inicio';
import {AuthState} from '@app/core/services/auth';
import {ActivatedRoute} from '@angular/router';
import {AlumnoInicio} from '@app/features/alumno/inicio/models/alumno-inicio.model';
import {DocenteInicio} from '@app/features/docente/inicio/models/docente-inicio.model';
import {DatosDocente} from '@app/shared/ui/datos-docente/datos-docente';

@Component({
  selector: 'app-current-docente-header',
  imports: [
    DatosDocente
  ],
  template: `
    @if (info(); as data) {
      <app-datos-docente
        [nombre]="data.nombre"
        [academia]="data.academia"
        [titulo]="pageTitle()"
      />
    }
  `
})
export class CurrentDocenteHeader {
  private inicio = inject(InicioState);
  private route = inject(ActivatedRoute);
  protected pageTitle = computed(() => (this.route.snapshot.title || ''));

  protected info = computed(() => {
    const details = this.inicio.as<DocenteInicio>()();

    if (!details) return null;

    return {
      academia: details.academia,
      nombre: details.nombre
    };
  });
}
