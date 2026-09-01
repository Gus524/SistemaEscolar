import {AlumnoHorario} from '@app/core/models/horario/alumno-horario.model';
import {DocenteHorario} from '@app/core/models/horario/docente-horario.model';
import {HorarioGeneral} from '@app/core/models/horario/horario-general.model';

export type HorarioType = AlumnoHorario | DocenteHorario | HorarioGeneral;
export type HorarioVariant = 'publico' | 'alumno' | 'docente';
