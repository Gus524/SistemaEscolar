import {Component, inject} from '@angular/core';
import {HorarioForm} from '@app/features/common/horario/component/horario-form/horario-form';
import {HorarioState} from '@app/features/common/horario/services/horario-state';
import {HorarioTable} from '@app/shared/ui/horario-table/horario-table';

@Component({
  selector: 'app-horarios-page',
  imports: [
    HorarioForm,
    HorarioTable
  ],
  template: `
    <app-horario-form />
    <hr class="custom-hr">
    @if (state.horarios() !== null) {
      <app-horario-table [horario]="state.horarios()" [variant]="'publico'"/>
    }
  `
})
export class HorariosPage {
  protected state = inject(HorarioState);
}
