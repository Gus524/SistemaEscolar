import {User} from '@app/core/models/user/user.model';
import {UserAuthResponse} from '@app/core/models/user/user-auth.response';

export const userAdapter = (auth: UserAuthResponse): User => {
  return { usuario: auth.userName, tipoUsuario: auth.tipo }
}
