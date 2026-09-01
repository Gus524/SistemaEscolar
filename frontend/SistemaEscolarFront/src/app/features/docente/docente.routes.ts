import {Routes} from '@angular/router';

export const docenteRoutes: Routes = [
  {
    path: '',
    loadComponent: () => import('./inicio/pages/docente-inicio-page/docente-inicio-page')
      .then(m => m.DocenteInicioPage),
    title: 'Inicio'
  },
  {
    path: 'horario',
    loadComponent: () => import('./horario/pages/docente-horario-page/docente-horario-page')
      .then(m => m.DocenteHorarioPage),
    title: 'Horario actual'
  },
  {
    path: 'datos-personales',
    loadComponent: () => import('./datos-personales/mis-datos-docente/mis-datos-docente')
      .then(m => m.MisDatosDocente),
    title: 'Datos personales'
  },
  {
    path: 'grupos',
    loadComponent: () => import('@app/shared/ui/under-construction-page/under-construction-page')
      .then(m => m.UnderConstructionPage),
    data: { title: 'Mis Grupos', message: 'Listado general de grupos asignados y gestión de listas de asistencia.' },
    title: 'Mis Grupos'
  },
  {
    path: 'agenda',
    loadComponent: () => import('@app/shared/ui/under-construction-page/under-construction-page')
      .then(m => m.UnderConstructionPage),
    data: { title: 'Agenda Docente', message: 'Eventos académicos y fechas de evaluación.' },
    title: 'Agenda'
  },
  {
    path: 'calendario-ets',
    loadComponent: () => import('@app/shared/ui/under-construction-page/under-construction-page')
      .then(m => m.UnderConstructionPage),
    data: { title: 'Calendario de ETS', message: 'Programación de exámenes extraordinarios.' },
    title: 'Calendario ETS'
  }
];
