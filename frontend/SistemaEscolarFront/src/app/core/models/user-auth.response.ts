import {TipoUsuario} from '@app/core/enums';

export interface UserAuthResponse {
  userName: string;
  tipo: TipoUsuario;
}
