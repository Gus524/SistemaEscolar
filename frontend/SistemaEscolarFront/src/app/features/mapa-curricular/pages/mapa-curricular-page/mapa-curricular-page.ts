import {Component, effect, inject, output} from '@angular/core';
import {NonNullableFormBuilder, ReactiveFormsModule, Validators} from '@angular/forms';
import {FiltroMapaForm, FiltrosMapa} from '@app/core/models/filtros';
import {CarreraPlanSelector} from '@app/shared/ui/carrera-plan-selector/carrera-plan-selector';
import {MapaCurricularState} from '@app/features/mapa-curricular/services/mapa-curricular-state';
import {toSignal} from '@angular/core/rxjs-interop';
import {
  MapaCurricularTable
} from '@app/features/mapa-curricular/components/mapa-curricular-table/mapa-curricular-table';
import {Loader} from '@app/shared/ui/loader/loader';

@Component({
  selector: 'app-mapa-curricular-page',
  imports: [
    CarreraPlanSelector,
    ReactiveFormsModule,
    MapaCurricularTable
  ],
  template: `
    <form [formGroup]="formMapa">
      <app-carrera-plan-selector />
    </form>
    <hr>
    @if (!state.loading()) {
      <app-mapa-curricular-table />
    }
  `,
  styleUrl: './mapa-curricular-page.scss'
})
export class MapaCurricularPage {
  private fb = inject(NonNullableFormBuilder);
  protected state = inject(MapaCurricularState);

  search = output<FiltrosMapa>();

  formMapa = this.fb.group<FiltroMapaForm>({
    carrera: this.fb.control(null, Validators.required),
    plan: this.fb.control({ value: null, disabled: true }, Validators.required)
  });

  formValue = toSignal(this.formMapa.valueChanges);

  constructor() {
    effect(() => {
      const value = this.formValue();

      if (this.formMapa.valid && this.formValue()?.plan != null) {
        this.state.setFilters({ carrera: value?.carrera!, plan: value?.plan! });

        this.state.getMapa();
      }
    });
  }
}
