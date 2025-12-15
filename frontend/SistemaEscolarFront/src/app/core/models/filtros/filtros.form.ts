import {FormControl} from '@angular/forms';

export interface FiltrosBaseForm {
  carrera: FormControl<string | null>;
  plan: FormControl<number | null>;
}
export const TURNOS = [
  { value: 'M', label: 'Matutino' },
  { value: 'V', label: 'Vespertino' },
];

export interface FiltroMapaForm extends FiltrosBaseForm {}
export interface FiltroHorarioForm extends FiltrosBaseForm {
  turno: FormControl<string | null>;
  semestre: FormControl<number | null>;
  materia: FormControl<string | null>;
  grupo: FormControl<string | null>;
}

export const SEMESTRES = [
  { semestre: 1 },
  { semestre: 2 },
  { semestre: 3 },
  { semestre: 4 },
  { semestre: 5 },
  { semestre: 6 },
  { semestre: 7 },
  { semestre: 8 },
]
