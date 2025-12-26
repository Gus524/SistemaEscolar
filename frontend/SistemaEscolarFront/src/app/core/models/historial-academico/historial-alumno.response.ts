import {HistorialAlumno} from '@app/core/models/historial-academico/historial-alumno.model';
import {SemestreHistorial} from '@app/core/models/historial-academico/semestre-historial.model';

export interface HistorialAlumnoResponse {
  historialAlumno: HistorialAlumno;
  semestreHistorial: SemestreHistorial[];
}
