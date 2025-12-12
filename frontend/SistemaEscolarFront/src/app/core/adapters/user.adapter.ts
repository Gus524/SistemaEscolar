import {AuthResponse} from '@app/core/models/auth.response';
import {User} from '@app/core/models/user.model';

export const userAdapter = (auth: AuthResponse): User => {
  return { usuario: auth.user, nombre: auth.userName, tipoUsuario: auth.role }
}
