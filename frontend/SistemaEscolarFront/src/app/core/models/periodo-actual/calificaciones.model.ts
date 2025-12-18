export interface Califcaciones {
  periodo: number;
  grupo: string;
  materia: string;
  clave: string;
  primerParcial?: string | '-';
  segundoParcial?: string | '-';
  tercerParcial?: string | '-';
  extra?: string | '-';
  final?: string | '-';
}
