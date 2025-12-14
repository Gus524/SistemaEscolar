import {User} from '@app/core/models/user/user.model';
import {UserAuthResponse} from '@app/core/models/user/user-auth.response';

export interface AuthResponse {
  token: string;
  user: UserAuthResponse;
}
