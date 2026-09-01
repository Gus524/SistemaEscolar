import {inject, Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {API_URL} from '@app/core/config/api.token';
import {AuthRequest} from '@app/core/models/auth/auth.request';
import {map, Observable} from 'rxjs';
import {AuthResponse} from '@app/core/models/auth/auth.response';
import {ApiResponse} from '@app/core/models/api.response';
import {publicContext} from '@app/core/contexts/public.context';
import {UserAuthResponse} from '@app/core/models/user/user-auth.response';

@Injectable({
  providedIn: 'root'
})
export class AuthApi {
  private http = inject(HttpClient);
  private url = `${inject(API_URL)}Auth`;

  login(request: AuthRequest): Observable<AuthResponse> {
    return this.http
      .post<ApiResponse<AuthResponse>>(`${this.url}/auth`, request,
        { context: publicContext() }
      ).pipe(
        map(response => response.data)
      );
  }

  me(): Observable<UserAuthResponse> {
    return this.http
      .get<ApiResponse<UserAuthResponse>>(`${this.url}/me`)
      .pipe(map(response => response.data));
  }
}
