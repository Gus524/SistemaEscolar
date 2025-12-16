export interface HorarioGeneralResponse {
  secuencia: string;
  clave: string;
  nombreProfesor: string;
  materia: string;
  lunes?: string | '-';
  martes?: string | '-';
  miercoles?: string | '-';
  jueves?: string | '-';
  viernes?: string | '-';
}
