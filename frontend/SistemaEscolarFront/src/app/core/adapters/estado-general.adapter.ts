import {EstadoGeneralResponse} from '@app/core/models/historial-academico/estado-general.response';
import {EstadoGeneral} from '@app/core/models/historial-academico/estado-general.model';

export const estadoGeneralAdapter = (e: EstadoGeneralResponse): EstadoGeneral => {
  return { academia: e.nomAcademia, ...e }
}
