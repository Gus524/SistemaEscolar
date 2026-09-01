import {Component, computed, DestroyRef, effect, inject, OnInit, signal} from '@angular/core';
import {CatalogoAcademicoState} from '@app/core/services/catalogo-academico/catalogo-academico-state';
import {ControlContainer, FormGroup, FormGroupDirective, ReactiveFormsModule} from '@angular/forms';
import {FiltrosBaseForm} from '@app/core/models/filtros';
import {takeUntilDestroyed, toSignal} from '@angular/core/rxjs-interop';
import {startWith} from 'rxjs';

@Component({
  selector: 'app-carrera-plan-selector',
  imports: [
    ReactiveFormsModule
  ],
  viewProviders: [{ provide: ControlContainer, useExisting: FormGroupDirective }],
  template: `
    <fieldset [formGroup]="parentForm" class="carrera-plan-form">
      <label class="form-control">
        <span class="label-text">Carrera</span>
        <select formControlName="carrera">
          <option [value]="null" disabled selected>Selecciona una carrera</option>
          @for (c of state.carreras(); track c.abreviatura) {
            <option [value]="c.abreviatura">{{c.carrera}}</option>
          }
        </select>
      </label>
      <label class="form-control">
        <span class="label-text">Plan de estudios</span>
        <select formControlName="plan">
          <option [value]="null" disabled selected>
            {{ !carreraSeleccionada() ? 'Selecciona una carrera primero' : 'Selecciona un plan' }}
          </option>
          @for (p of planesDisponibles(); track p.idPlan) {
            <option [value]="p.idPlan">{{ p.plan }}</option>
          }
        </select>
      </label>
    </fieldset>
  `
})
export class CarreraPlanSelector implements OnInit {
  protected state = inject(CatalogoAcademicoState);
  private destroyRef = inject(DestroyRef);
  private parentDir = inject(FormGroupDirective);

  carreraSeleccionada = signal<string | null>(null);

  planesDisponibles = computed(() =>
    this.state.getPlanByCarrera(this.carreraSeleccionada())
  );

  get parentForm(): FormGroup<FiltrosBaseForm> {
    return this.parentDir.form as FormGroup<FiltrosBaseForm>;
  }

  constructor() {
    effect(() => {
      const carrera = this.carreraSeleccionada();
      const planControl = this.parentForm.controls.plan;

      if (carrera) {
        planControl.enable({ emitEvent: false});
      } else {
        planControl.disable({ emitEvent: false });
        planControl.setValue(null, { emitEvent: false });
      }
    });
  }

  ngOnInit(): void {
    const form = this.parentForm;

    if (!form) {
      return;
    }

    const carreraControl = form.controls.carrera;

    carreraControl.valueChanges
      .pipe(
        startWith(carreraControl.value),
        takeUntilDestroyed(this.destroyRef)
      )
      .subscribe((valor) => {
        this.carreraSeleccionada.set(valor);
      });
  }
}
