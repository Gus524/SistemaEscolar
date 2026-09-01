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
  },
  {
    path: 'ocupabilidad',
    loadComponent: () => import('@app/shared/ui/under-construction-page/under-construction-page')
      .then(m => m.UnderConstructionPage),
    data: {
      title: 'Ocupabilidad',
      message: 'Estamos optimizando la consulta de cupos disponibles por grupo y asignatura.'
    },
    title: 'Ocupabilidad'
  }
]
