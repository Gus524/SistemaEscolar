export interface AlumnoHorario {
  grupo: string;
  materia: string;
  nombreDocente?: string;
  clave: string;
  lunes?: string | '-';
  martes?: string | '-';
  miercoles?: string | '-';
  jueves?: string | '-';
  viernes?: string | '-';
}
