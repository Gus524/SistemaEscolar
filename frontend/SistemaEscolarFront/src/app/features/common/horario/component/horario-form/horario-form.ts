import {Component, effect, inject} from '@angular/core';
import {NonNullableFormBuilder, ReactiveFormsModule, Validators} from '@angular/forms';
import {FiltroHorarioForm, SEMESTRES, TURNOS} from '@app/core/models/filtros';
import {CarreraPlanSelector} from '@app/shared/ui/carrera-plan-selector/carrera-plan-selector';
import {HorarioState} from '@app/features/common/horario/services/horario-state';
import {toSignal} from '@angular/core/rxjs-interop';
import {debounceTime} from 'rxjs';
import {HorarioFilters} from '@app/core/models/horario';

@Component({
  selector: 'app-horario-form',
  imports: [
    ReactiveFormsModule,
    CarreraPlanSelector
  ],
  template: `
    <form [formGroup]="form" class="horario-layout">

      <app-carrera-plan-selector class="full-width" />

      <fieldset class="filtros-adicionales">

        <label class="form-control">
          <span class="label-text">Turno</span>
          <select formControlName="turno">
            <option [ngValue]="null">Todos</option>
            @for (t of turnos; track t.value) {
              <option [value]="t.value">{{t.label}}</option>
            }
          </select>
        </label>

        <label class="form-control">
          <span class="label-text">Semestre</span>
          <select formControlName="semestre">
            <option [ngValue]="null">Todos</option>
            @for (s of semestres; track s.semestre) {
              <option [value]="s.semestre">{{s.semestre}}</option>
            }
          </select>
        </label>

        <label class="form-control">
          <span class="label-text">Grupo</span>
          <select formControlName="grupo">
            <option [value]="''">Todos</option> @for (g of grupos(); track $index) {
            <option [value]="g">{{ g }}</option>
          } @empty {
            <option disabled>Sin grupos disponibles</option>
          }
          </select>
        </label>

      </fieldset>
    </form>
  `,
  styleUrl: './horario-form.scss'
})
export class HorarioForm {
  state = inject(HorarioState);
  fb = inject(NonNullableFormBuilder);
  grupos = this.state.secuencias;
  turnos = TURNOS;
  semestres = SEMESTRES;

  form = this.fb.group<FiltroHorarioForm>({
    carrera: this.fb.control(null, Validators.required),
    plan: this.fb.control({ value: null, disabled: true }, Validators.required),
    grupo: this.fb.control(null),
    materia: this.fb.control(null),
    semestre: this.fb.control(null),
    turno: this.fb.control(null),
  });

  grupoValue = toSignal(
    this.form.controls.grupo.valueChanges.pipe(
      debounceTime(300)
    ));

  formValues = toSignal(
    this.form.valueChanges.pipe(
      debounceTime(300)
    )
  );

  constructor() {
    effect(() => {
      const val = this.formValues();

      const grupo = this.grupoValue();

      if (grupo && grupo !== '') {
        this.state.getHorarioPorGrupo(grupo);
        return;
      }

      if (val && val.plan) {
        const filters: HorarioFilters = {
          idPlan: val.plan,
          semestre: val.semestre,
          turno: val.turno
        };
        this.state.setFilters(filters);

        if (val.semestre) this.state.getSecuencias();

        this.state.getHorarios();
      }
    });
  }
}
