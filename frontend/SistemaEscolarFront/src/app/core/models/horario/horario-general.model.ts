export interface HorarioGeneral {
  grupo: string;
  clave: string;
  nombreDocente?: string;
  materia: string;
  lunes?: string | '-';
  martes?: string | '-';
  miercoles?: string | '-';
  jueves?: string | '-';
  viernes?: string | '-';
}
