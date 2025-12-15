import {CarreraResponse} from '@app/core/models/carrera/carrera.response';
import {Carrera} from '@app/core/models/carrera';

export const carreraAdapter = (c: CarreraResponse): Carrera => {
  return { abreviatura: c.abrCarr, semestres: c.numeroSemestres, ...c };
}
