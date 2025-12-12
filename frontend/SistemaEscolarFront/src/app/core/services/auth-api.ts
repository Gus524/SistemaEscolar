import {inject, Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {API_URL} from '@app/core/config/api.token';
import {AuthRequest} from '@app/features/login/models/auth.request';
import {map, Observable} from 'rxjs';
import {AuthResponse} from '@app/features/login/models/auth.response';
import {ApiResponse} from '@app/core/models/api.response';
import {publicContext} from '@app/core/contexts/public.context';

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
}
