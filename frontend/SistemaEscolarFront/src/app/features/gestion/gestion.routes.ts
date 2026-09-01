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
  }
];
