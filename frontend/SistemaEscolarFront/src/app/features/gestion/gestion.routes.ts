import {Routes} from '@angular/router';

export const gestionRoutes: Routes = [
  {
    path: '',
    loadComponent: () => import('@app/features/gestion/inicio/pages/gestion-inicio-page/gestion-inicio-page')
      .then(m => m.GestionInicioPage),
    title: 'Inicio'
  }
];
