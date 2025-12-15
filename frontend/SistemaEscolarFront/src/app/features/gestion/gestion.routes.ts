import {Routes} from '@angular/router';

export const gestionRoutes: Routes = [
  {
    path: '',
    loadComponent: () => import('@app/features/gestion/inicio/pages/gestion-inicio-page/gestion-inicio-page')
      .then(m => m.GestionInicioPage),
    title: 'Inicio'
  },
  {
    path: 'alumnos',
    loadComponent: () => import('@app/shared/ui/under-construction-page/under-construction-page')
      .then(m => m.UnderConstructionPage),
    data: { title: 'Gestión de Alumnos', message: 'Módulo para la administración, búsqueda y edición de alumnos inscritos.' },
    title: 'Alumnos'
  },
  {
    path: 'docentes',
    loadComponent: () => import('./docentes/pages/gestion-docentes-page/gestion-docentes-page')
      .then(m => m.GestionDocentesPage),
    title: 'Docentes'
  },
  {
    path: 'horarios-editar',
    loadComponent: () => import('@app/shared/ui/under-construction-page/under-construction-page')
      .then(m => m.UnderConstructionPage),
    data: { title: 'Edición de Horarios', message: 'Herramienta administrativa para la creación y modificación de la oferta académica.' },
    title: 'Editar Horarios'
  },
  {
    path: 'tramites/solicitudes',
    loadComponent: () => import('@app/shared/ui/under-construction-page/under-construction-page')
      .then(m => m.UnderConstructionPage),
    data: { title: 'Bandeja de Solicitudes', message: 'Revisión y validación de trámites solicitados por los alumnos.' },
    title: 'Solicitudes'
  },
  {
    path: 'tramites/seguimiento',
    loadComponent: () => import('@app/shared/ui/under-construction-page/under-construction-page')
      .then(m => m.UnderConstructionPage),
    data: { title: 'Seguimiento de Trámites', message: 'Historial y estatus de trámites procesados.' },
    title: 'Seguimiento'
  },
  {
    path: 'agenda',
    loadComponent: () => import('@app/shared/ui/under-construction-page/under-construction-page')
      .then(m => m.UnderConstructionPage),
    data: { title: 'Agenda Administrativa', message: 'Gestión de eventos escolares y fechas importantes.' },
    title: 'Agenda'
  },
  {
    path: 'equivalencias',
    loadComponent: () => import('@app/shared/ui/under-construction-page/under-construction-page')
      .then(m => m.UnderConstructionPage),
    data: { title: 'Gestión de Equivalencias', message: 'Administración de tablas de revalidación y equivalencias.' },
    title: 'Equivalencias'
  },
  {
    path: 'calendario-ets',
    loadComponent: () => import('@app/shared/ui/under-construction-page/under-construction-page')
      .then(m => m.UnderConstructionPage),
    data: { title: 'Programación de ETS', message: 'Configuración de fechas y asignación de aulas para ETS.' },
    title: 'Calendario ETS'
  },
  {
    path: 'horario',
    loadChildren: () => import('./horario/horario.routes')
      .then(m => m.horarioRoutes)
  },
  {
    path: 'historial-academico',
    loadChildren: () => import('./historial-academico/historial.routes')
      .then(m => m.historialRoutes)
  },
  {
    path: 'alumno/datos-personales/:boleta',
    loadComponent: () => import('./datos-personales/pages/gestion-datos-alumno/gestion-datos-alumno')
      .then(m => m.GestionDatosAlumno),
    title: 'Datos personales alumno'
  },
  {
    path: 'docente/datos-personales/:rfc',
    loadComponent: () => import('./datos-personales/pages/gestion-datos-docente/gestion-datos-docente')
      .then(m => m.GestionDatosDocente),
    title: 'Datos personales docente'
  },
  {
    path: 'alumno/calificaciones/:boleta',
    loadComponent: () => import('./calificaciones/pages/gestion-calificaciones-alumno/gestion-calificaciones-alumno')
      .then(m => m.GestionCalificacionesAlumno),
    title: 'Calificaciones alumno'
  }
];
