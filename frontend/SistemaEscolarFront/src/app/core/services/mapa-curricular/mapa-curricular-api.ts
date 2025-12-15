import {inject, Injectable} from '@angular/core';
import {HttpClient, HttpParams} from '@angular/common/http';
import {API_URL} from '@app/core/config/api.token';
import {map, Observable} from 'rxjs';
import {Carrera} from '@app/core/models/carrera';
import {CarreraResponse} from '@app/core/models/carrera/carrera.response';
import {ApiResponse} from '@app/core/models';
import {carreraAdapter} from '@app/core/adapters';
import {Plan} from '@app/core/models/planes/plan.model';
import {MapaCurricular, MapaCurricularFilters} from '@app/core/models/mapa-curricular';

@Injectable({
  providedIn: 'root'
})
export class MapaCurricularApi {
  private http = inject(HttpClient);
  private url = `${inject(API_URL)}MapaCurricular`;

  getCarreras(institucion: number): Observable<Carrera[]> {
    return this.http.get<ApiResponse<CarreraResponse[]>>(`${this.url}/carreras/${institucion}`)
      .pipe(
        map(response => response.data.map(carreraAdapter))
      );
  }

  getPlanes(carrera: string): Observable<Plan[]> {
    return this.http.get<ApiResponse<Plan[]>>(`${this.url}/planes/${carrera}`)
      .pipe(map(response => response.data));
  }

  getMapa(filters: MapaCurricularFilters): Observable<MapaCurricular[]> {
    let params = new HttpParams()
      .set('carrera', filters.carrera)
      .set('plan', filters.plan);

    return this.http.get<ApiResponse<MapaCurricular[]>>(`${this.url}/mapaCurricular`, { params }
    ).pipe(
      map(response => response.data)
    );
  }
}
