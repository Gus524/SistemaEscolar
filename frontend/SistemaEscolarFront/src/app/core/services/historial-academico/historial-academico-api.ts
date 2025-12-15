import {inject, Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {API_URL} from '@app/core/config/api.token';
import {map, Observable} from 'rxjs';
import {
  EstadoGeneral,
  EstadoGeneralResponse,
  HistorialAlumno,
  HistorialAlumnoResponse
} from '@app/core/models/historial-academico';
import {ApiResponse} from '@app/core/models';
import {estadoGeneralAdapter} from '@app/core/adapters';

@Injectable({
  providedIn: 'root'
})
export class HistorialAcademicoApi {
  private http = inject(HttpClient);
  private url = `${inject(API_URL)}HistorialAcademico`;

  getHistorialDetalle(boleta?: number): Observable<HistorialAlumnoResponse> {
    if (boleta) {
      return this.http
        .get<ApiResponse<HistorialAlumnoResponse>>(`${this.url}/detalle`,
        { params: { noBoleta: boleta } })
          .pipe(map(response => response.data)
        );
    } else {
      return this.http
        .get<ApiResponse<HistorialAlumnoResponse>>(`${this.url}/historialAlumno`)
        .pipe(map(response => response.data))
    }
  }

  getEstadoGeneral(boleta: number, idPlan: number): Observable<EstadoGeneral[]> {
    return this.http.get<ApiResponse<EstadoGeneralResponse[]>>(`${this.url}/estadoGeneral`,
      { params: { noBoleta: boleta, idPlan: idPlan }})
      .pipe(map(response => response.data.map(estadoGeneralAdapter)))
  }

  getHistorialAlumno(boleta: number): Observable<HistorialAlumno> {
    return this.http.get<ApiResponse<HistorialAlumno>>(`${this.url}/alumno`,
      { params: { noBoleta: boleta } })
    .pipe(map(response => response.data));
  }
}
