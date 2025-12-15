import {HorarioType} from '@app/shared/types/horario.type';
import {HorarioGeneral, HorarioTableModel} from '@app/core/models/horario';
import {HorarioGeneralResponse} from '@app/core/models/horario/horario-general.response';

export const horarioAdapter = (horario: HorarioType): HorarioTableModel => {
  let inscritos: number | undefined;

  if ('inscritos' in horario) {
    inscritos = horario.inscritos;
  }

  let docente: string | undefined = '';
  if ('nombreDocente' in horario) {
    docente = horario.nombreDocente;
  }

  return {
    grupo: horario.grupo,
    inscritos: inscritos,
    clave: horario.clave,
    materia: horario.materia,
    docente: docente,
    lunes: horario.lunes ?? '-',
    martes: horario.martes ?? '-',
    miercoles: horario.miercoles ?? '-',
    jueves: horario.jueves ?? '-',
    viernes: horario.viernes ?? '-',
  }
}

export const horarioGeneralAdapter = (horario: HorarioGeneralResponse[]): HorarioGeneral[] => {
  return horario.map(h => ({
    grupo: h.secuencia,
    nombreDocente: h.nombreProfesor,
    ...h
  }));
}
