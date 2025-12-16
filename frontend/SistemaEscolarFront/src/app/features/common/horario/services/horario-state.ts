import {inject, Injectable, signal} from '@angular/core';
import {HorarioApi} from '@app/core/services/horario';
import {AsyncState} from '@app/core/utils/async-state.util';
import {HorarioFilters, HorarioTableModel} from '@app/core/models/horario';
import {horarioAdapter} from '@app/core/adapters';

@Injectable({
  providedIn: 'root'
})
export class HorarioState {
  private api = inject(HorarioApi);
  private _async = new AsyncState();

  #secuencias = signal<string[] | null>(null);
  secuencias = this.#secuencias.asReadonly();

  #horarioFilters = signal<HorarioFilters | null>(null);

  #horarios = signal<HorarioTableModel[] | null>(null);
  horarios = this.#horarios.asReadonly();

  getSecuencias(){
    if (this.#horarioFilters() !== null) {
      this._async.execute(
        this.api.getSecuencias(this.#horarioFilters()!),
        response =>
          this.#secuencias.set(response)
      );
    }
  }

  setFilters(horario: HorarioFilters){
    this.#horarioFilters.set(horario);
  }

  getHorarios() {
    if (this.#horarioFilters() !== null) {
      this._async.execute(
        this.api.getHorarioGeneral(this.#horarioFilters()!),
        response =>
          this.#horarios.set(response.map(horarioAdapter))
      );
    }
  }

  getHorarioPorGrupo(grupo: string) {
    this._async.execute(
      this.api.getHorarioPorGrupo(grupo),
      response =>
        this.#horarios.set(response.map(horarioAdapter))
    )
  }
}
