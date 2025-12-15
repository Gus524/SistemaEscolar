import {Routes} from '@angular/router';

export const commonRoutes: Routes = [
  {
    path: 'mapa-curricular',
    loadComponent: () => import('./mapa-curricular/pages/mapa-curricular-page/mapa-curricular-page')
      .then(m => m.MapaCurricularPage),
    title: 'Mapa Curricular'
  },
  {
    path: 'horarios',
    loadComponent: () => import('./horario/pages/horarios-page/horarios-page')
      .then(m => m.HorariosPage),
    title: 'Horarios de clase'
  }
]
