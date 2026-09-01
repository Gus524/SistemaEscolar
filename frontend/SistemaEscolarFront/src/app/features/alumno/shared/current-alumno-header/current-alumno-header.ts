import {Component, computed, inject} from '@angular/core';
import {DatosAlumno} from '@app/shared/ui/datos-alumno/datos-alumno';
import {InicioState} from '@app/core/services/inicio';
import {AuthState} from '@app/core/services/auth';
import {AlumnoInicio} from '@app/features/alumno/inicio/models/alumno-inicio.model';
import {ActivatedRoute} from '@angular/router';

@Component({
  selector: 'app-current-alumno-header',
  imports: [
    DatosAlumno
  ],
  template: `
    @if (info(); as data) {
      <app-datos-alumno
        [nombre]="data.nombre"
        [boleta]="data.boleta"
        [titulo]="pageTitle()"
      />
    }
  `
})
export class CurrentAlumnoHeader {
  private inicio = inject(InicioState);
  auth = inject(AuthState);
  private route = inject(ActivatedRoute);
  protected pageTitle = computed(() => (this.route.snapshot.title || ''));

  protected info = computed(() => {
    const user = this.auth.currentUser();
    const details = this.inicio.as<AlumnoInicio>()();

    if (!user || !details) return null;

    return {
      boleta: user.usuario,
      nombre: details.nombre
    };
  });
}
