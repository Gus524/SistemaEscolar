import {TipoUsuario} from '@app/core/enums/tipo-usuario.enum';

export interface AuthResponse {
  token: string;
  user: string;
  userName: string;
  role: TipoUsuario
}
