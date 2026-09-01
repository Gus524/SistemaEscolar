export interface FiltrosBase {
  carrera: string | null;
  plan: number | null;
}


export interface FiltrosHorario extends FiltrosBase {
  turno: string | null;
  semestre: number | null;
  materia: string | null;
  grupo: string | null;
}

export type FiltrosMapa = FiltrosBase;
