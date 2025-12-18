import {inject, Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {API_URL} from '@app/core/config/api.token';
import {map, Observable} from 'rxjs';
import {Califcaciones} from '@app/core/models/periodo-actual/calificaciones.model';
import {ApiResponse} from '@app/core/models';

@Injectable({
  providedIn: 'root'
})
export class PeriodoActualApi {
  private http = inject(HttpClient);
  private url = `${inject(API_URL)}PeriodoActual`;

  getCalificacionesAlumno(boleta?: number, plan?: number): Observable<Califcaciones[]> {
    if (boleta && plan) {
      return this.http.get<ApiResponse<Califcaciones[]>>(`${this.url}/calificaciones`, {
        params: {
          noBoleta: boleta,
          plan: plan
        }
      })
        .pipe(
          map(response => response.data)
        );
    } else {
      return this.http.get<ApiResponse<Califcaciones[]>>(`${this.url}/misCalificaciones`)
        .pipe(map(response => response.data));
    }
  }
}
