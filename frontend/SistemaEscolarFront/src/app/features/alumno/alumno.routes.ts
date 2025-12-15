import {Routes} from '@angular/router';

export const alumnoRoutes: Routes = [
  {
    path: '',
    loadComponent: () => import('./inicio/pages/alumno-inicio-page/alumno-inicio-page')
      .then(m => m.AlumnoInicioPage),
    title: 'Inicio'
  },
  {
    path: 'horario-clases',
    loadComponent: () => import('./horario/pages/alumno-horario-page/alumno-horario-page')
      .then(m => m.AlumnoHorarioPage),
    title: 'Horario de clases'
  }
];
