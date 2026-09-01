export interface DocenteHorario {
  grupo: string;
  clave: string;
  inscritos: number;
  materia: string;
  lunes?: string | '-';
  martes?: string | '-';
  miercoles?: string | '-';
  jueves?: string | '-';
  viernes?: string | '-';
}
