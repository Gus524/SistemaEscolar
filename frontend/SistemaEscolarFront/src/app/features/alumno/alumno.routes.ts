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
  },
  {
    path: 'tramites/solicitud',
    loadComponent: () => import('@app/shared/ui/under-construction-page/under-construction-page')
      .then(m => m.UnderConstructionPage),
    data: { title: 'Solicitud de Trámites', message: 'Pronto podrás gestionar tus constancias y boletas desde aquí.' },
    title: 'Solicitud de Trámites'
  },
  {
    path: 'tramites/seguimiento',
    loadComponent: () => import('@app/shared/ui/under-construction-page/under-construction-page')
      .then(m => m.UnderConstructionPage),
    data: { title: 'Seguimiento de Trámites', message: 'El módulo de rastreo de solicitudes está en desarrollo.' },
    title: 'Seguimiento'
  },
  {
    path: 'agenda',
    loadComponent: () => import('@app/shared/ui/under-construction-page/under-construction-page')
      .then(m => m.UnderConstructionPage),
    data: { title: 'Agenda Escolar', message: 'Tu agenda personalizada con eventos y fechas importantes estará lista pronto.' },
    title: 'Agenda Escolar'
  },
  {
    path: 'equivalencias',
    loadComponent: () => import('@app/shared/ui/under-construction-page/under-construction-page')
      .then(m => m.UnderConstructionPage),
    data: { title: 'Equivalencias', message: 'Consulta de tablas de equivalencia entre planes de estudio.' },
    title: 'Equivalencias'
  },
  {
    path: 'calendario-ets',
    loadComponent: () => import('@app/shared/ui/under-construction-page/under-construction-page')
      .then(m => m.UnderConstructionPage),
    data: { title: 'Calendario de ETS', message: 'Las fechas para Exámenes a Título de Suficiencia se publicarán aquí.' },
    title: 'Calendario ETS'
  }
];
