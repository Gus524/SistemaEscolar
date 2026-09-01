import {DocenteInicio} from '@app/features/docente/inicio/models/docente-inicio.model';
import {AlumnoInicio} from '@app/features/alumno/inicio/models/alumno-inicio.model';
import {GestionInicio} from '@app/features/gestion/inicio/models/gestion-inicio.model';

export type InicioType =  AlumnoInicio | DocenteInicio | GestionInicio;
