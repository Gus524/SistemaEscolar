import {Component, computed, input, signal} from '@angular/core';
import {DatosPersonalesAlumno} from '@app/core/models/datos-personales/datos-alumno.model';
import {DatosPersonalesDocente} from '@app/core/models/datos-personales/datos-docente.model';
import {UserRole} from '@app/shared/types/user-role.type';

type TabOption = 'GENERALES' | 'DIRECCION' | 'ESCOLARES';
@Component({
  selector: 'app-datos-personales',
  imports: [],
  templateUrl: './datos-personales.html',
  styleUrl: './datos-personales.scss'
})
export class DatosPersonales {
  data = input.required<DatosPersonalesAlumno | DatosPersonalesDocente>();
  role = input.required<UserRole>();

  activeTab = signal<TabOption>('GENERALES');

  isAlumno = computed(() => this.role() === 'ALUMNO');

  alumnoData = computed(() =>
    this.isAlumno() ? (this.data() as DatosPersonalesAlumno) : null
  );

  docenteData = computed(() =>
    !this.isAlumno() ? (this.data() as DatosPersonalesDocente) : null
  );
}
