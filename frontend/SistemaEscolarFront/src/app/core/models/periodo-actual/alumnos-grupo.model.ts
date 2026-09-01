export interface AlumnosGrupo {
  rfc: string;
  noBoleta: number;
  emailPersonal: string;
  emailInstitucional?: string;
  grupo?: string;
  clave?: string;
  nombre: string;
  apellidoPaterno: string;
  apellidoMaterno: string;
  primerParcial?: number;
  segundoParcial?: number;
  tercerParcial?: number;
  extra?: number;
  final?: number;
}
