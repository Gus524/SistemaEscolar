import {TipoUsuario} from '@app/core/enums/tipo-usuario.enum';
export interface User {
  nombre: string;
  tipoUsuario: TipoUsuario;
}
