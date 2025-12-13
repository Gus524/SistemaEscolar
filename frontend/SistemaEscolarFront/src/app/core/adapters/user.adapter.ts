import {AuthResponse} from '@app/core/models/auth.response';
import {User} from '@app/core/models/user.model';
import {UserAuthResponse} from '@app/core/models/user-auth.response';

export const userAdapter = (auth: UserAuthResponse): User => {
  return { nombre: auth.userName, tipoUsuario: auth.tipo }
}
