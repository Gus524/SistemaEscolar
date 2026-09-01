import {MateriaDetalle} from '@app/core/models/historial-academico/materia-detalle.model';

export interface SemestreHistorial {
  semestre: number;
  materias: MateriaDetalle[];
}
