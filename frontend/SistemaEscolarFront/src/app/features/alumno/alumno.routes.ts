import {Routes} from '@angular/router';

export const alumnoRoutes: Routes = [
  {
    path: '',
    loadComponent: () => import('./inicio/pages/alumno-inicio-page/alumno-inicio-page')
      .then(m => m.AlumnoInicioPage),
    title: 'Inicio'
  },
  {
    path: 'comprobante-horario',
    loadComponent: () => import('./horario/pages/alumno-horario-page/alumno-horario-page')
      .then(m => m.AlumnoHorarioPage),
    title: 'Comprobante horario'
  },
  {
    path: 'calificaciones',
    loadComponent: () => import('./calificaciones/pages/mis-calificaciones-page/mis-calificaciones-page')
      .then(m => m.MisCalificacionesPage),
    title: 'Calificaciones'
  },
  {
    path: 'historial',
    loadComponent: () => import('./historial-academico/pages/mi-kardex/mi-kardex')
      .then(m => m.MiKardex),
    title: 'Historial académico'
  }
];
