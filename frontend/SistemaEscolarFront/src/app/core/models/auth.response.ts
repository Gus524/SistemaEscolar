import {User} from '@app/core/models/user.model';
import {UserAuthResponse} from '@app/core/models/user-auth.response';

export interface AuthResponse {
  token: string;
  user: UserAuthResponse;
}
