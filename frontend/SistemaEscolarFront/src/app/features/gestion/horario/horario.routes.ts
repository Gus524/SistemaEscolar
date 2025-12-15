import {Routes} from '@angular/router';

export const horarioRoutes: Routes = [
  {
    path: 'alumno/:boleta',
    loadComponent: () => import('./pages/gestion-alumno-horario/gestion-alumno-horario')
      .then(m => m.GestionAlumnoHorario),
    title: 'Horario alumno',
  },
  {
    path: 'docente/:rfc',
    loadComponent: () => import('./pages/gestion-docente-horario/gestion-docente-horario')
    .then(m => m.GestionDocenteHorario),
    title: 'Horario docente',
  }
]
