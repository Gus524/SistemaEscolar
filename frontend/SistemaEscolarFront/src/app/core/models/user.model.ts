import {TipoUsuario} from '@app/core/enums/tipo-usuario.enum';

export interface User {
  usuario: string;
  nombre: string;
  tipoUsuario: TipoUsuario;
}
