import { Routes } from '@angular/router';
import {MainLayout} from '@app/core/layout/main-layout/main-layout';
import {authGuard, redirectGuard, roleGuard} from '@app/core/guards';
import {TipoUsuario} from '@app/core/enums';

export const routes: Routes = [
  {
    path: 'login',
    loadComponent: () => import('./features/login/ui/pages/login/login')
      .then(m => m.Login),
    title: 'Iniciar sesión | School Shield'
  },

  {
    path: '',
    component: MainLayout,
    canMatch: [authGuard],
    children: [
      {
        path: '',
        pathMatch: 'full',
        canActivate: [redirectGuard],
        children: []
      },
      {
        path: 'alumno',
        canMatch: [roleGuard([TipoUsuario.alumno])],
        loadChildren: () => import('./features/alumno/alumno.routes')
          .then(m => m.alumnoRoutes)
      },
      {
        path: 'docente',
        canMatch: [roleGuard([TipoUsuario.docente])],
        loadChildren: () => import('./features/docente/docente.routes')
          .then(m => m.docenteRoutes)
      },
      {
        path: 'gestion',
        canMatch: [roleGuard([TipoUsuario.gestion])],
        loadChildren: () => import('./features/gestion/gestion.routes')
          .then(m => m.gestionRoutes)
      }
    ]
  },
  {
    path: '**',
    redirectTo: 'login',
  }
];
