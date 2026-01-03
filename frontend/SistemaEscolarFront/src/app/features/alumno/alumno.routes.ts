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
  },
  {
    path: 'estado-general',
    loadComponent: () => import('./historial-academico/pages/mi-estado-general/mi-estado-general')
      .then(m => m.MiEstadoGeneral),
    title: 'Estado general'
  },
  {
    path: 'datos-personales',
    loadComponent: () => import('./datos-personales/pages/mis-datos-alumno/mis-datos-alumno')
      .then(m => m.MisDatosAlumno),
    title: 'Datos personales'
  }
];
