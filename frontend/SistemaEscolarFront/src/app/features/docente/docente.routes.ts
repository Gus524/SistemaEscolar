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
  }
];
