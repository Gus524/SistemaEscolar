import {Routes} from '@angular/router';

export const historialRoutes: Routes = [
  {
    path: 'estado-general/:boleta',
    loadComponent: () => import('./pages/gestion-estado-general-alumno/gestion-estado-general-alumno')
      .then(m => m.GestionEstadoGeneralAlumno),
    title: 'Estado general'
  },
  {
    path: 'historial/:boleta',
    loadComponent: () => import('./pages/kardex-alumno/kardex-alumno')
      .then(m => m.KardexAlumno),
    title: 'Historial alumno'
  }
]
