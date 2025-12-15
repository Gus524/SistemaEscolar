import {inject, Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {API_URL} from '@app/core/config/api.token';
import {map, Observable} from 'rxjs';
import {DatosPersonalesAlumno} from '@app/core/models/datos-personales/datos-alumno.model';
import {ApiResponse} from '@app/core/models';
import {DatosPersonalesDocente} from '@app/core/models/datos-personales/datos-docente.model';

@Injectable({
  providedIn: 'root'
})
export class DatosPersonalesApi {
  private http = inject(HttpClient);
  private url = `${inject(API_URL)}DatosPersonales`;

  getDatosAlumno(boleta?: number): Observable<DatosPersonalesAlumno> {
    if (boleta) {
      return this.http
      .get<ApiResponse<DatosPersonalesAlumno>>(`${this.url}.datosAlumno`,
        { params: { noBoleta: boleta }})
      .pipe(map(response => response.data));
    } else {
      return this.http.get<ApiResponse<DatosPersonalesAlumno>>(`${this.url}/misDatosAlumno`)
        .pipe(map(response => response.data));
    }
  }

  getDatosDocente(rfc?: string): Observable<DatosPersonalesDocente> {
    if (rfc) {
      return this.http
        .get<ApiResponse<DatosPersonalesDocente>>(`${this.url}/datosDocente`,
          { params: { rfc: rfc }})
        .pipe(map(response => response.data));
    } else {
      return this.http.get<ApiResponse<DatosPersonalesDocente>>(`${this.url}/misDatosDocente`)
        .pipe(map(response => response.data));
    }
  }
}
