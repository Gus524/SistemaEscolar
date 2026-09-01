import {inject, Injectable} from '@angular/core';
import {HttpClient, HttpParams} from '@angular/common/http';
import {API_URL} from '@app/core/config/api.token';
import {filter, map, Observable} from 'rxjs';
import {DocenteHorario} from '@app/core/models/horario/docente-horario.model';
import {ApiResponse} from '@app/core/models';
import {AlumnoHorario} from '@app/core/models/horario/alumno-horario.model';
import {HorarioGeneralResponse} from '@app/core/models/horario/horario-general.response';
import {HorarioFilters} from '@app/core/models/horario/horario.filters';
import {HorarioGeneral} from '@app/core/models/horario';
import {horarioGeneralAdapter} from '@app/core/adapters/horario.adapter';

@Injectable({
  providedIn: 'root'
})
export class HorarioApi {
  private http = inject(HttpClient);
  private url = `${inject(API_URL)}Horario`;

  getDocenteHorario(rfc?: string): Observable<DocenteHorario[]> {
    if (rfc !== undefined) {
      return this.http.get<ApiResponse<DocenteHorario[]>>(`${this.url}/docente`, { params: { rfc }})
        .pipe(map(response => response.data));
    } else {
      return this.http.get<ApiResponse<DocenteHorario[]>>(`${this.url}/miHorarioDocente`)
        .pipe(map(response => response.data));
    }
  }

  getAlumnoHorario(boleta?: number): Observable<AlumnoHorario[]> {
    if (boleta !== undefined) {
      return this.http.get<ApiResponse<AlumnoHorario[]>>(`${this.url}/alumno`,
        { params: { noBoleta: boleta} })
        .pipe(map(response => response.data));
    } else {
      return this.http.get<ApiResponse<AlumnoHorario[]>>(`${this.url}/miHorarioAlumno`)
        .pipe(map(response => response.data));
    }
  }

  getHorarioGeneral(filters: HorarioFilters): Observable<HorarioGeneral[]> {
    return this.http.get<ApiResponse<HorarioGeneralResponse[]>>(`${this.url}/general`,
      { params: this.getParams(filters) })
      .pipe(map(response => horarioGeneralAdapter(response.data)));
  }

  getHorarioPorGrupo(grupo: string): Observable<HorarioGeneral[]> {
    return this.http.get<ApiResponse<HorarioGeneralResponse[]>>(`${this.url}/grupo/${grupo}`)
     .pipe(map(response => horarioGeneralAdapter(response.data)));
  }

  getSecuencias(filters: HorarioFilters): Observable<string[]> {
    return this.http.get<ApiResponse<string[]>>(`${this.url}/secuencias`,
      { params: this.getParams(filters) })
    .pipe(map(response => response.data));
  }

  private getParams(filters: HorarioFilters): HttpParams {
    let params = new HttpParams()
      .set('idPlan', filters.idPlan.toString());

    if (filters.semestre !== null && filters.semestre !== undefined) {
      params = params.set('semestre', filters.semestre.toString());
    }

    if (filters.turno !== null && filters.turno !== undefined) {
      params = params.set('turno', filters.turno.toString());
    }

    return params;
  }
}
