import {inject, Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {API_URL} from '@app/core/config/api.token';
import {map, Observable} from 'rxjs';
import {InicioType} from '@app/shared/types/inicio.type';
import {ApiResponse} from '@app/core/models';

@Injectable({
  providedIn: 'root'
})
export class InicioApi {
  private http = inject(HttpClient);
  private url = `${inject(API_URL)}Inicio`;

  getInicio(): Observable<InicioType> {
    return this.http.get<ApiResponse<InicioType>>(`${this.url}`)
      .pipe(map(response => response.data));
  }
}
