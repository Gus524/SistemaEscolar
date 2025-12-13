import {CanActivateFn, Router, UrlTree} from '@angular/router';
import {inject} from '@angular/core';
import {AuthState} from '@app/core/services/auth';
import {TipoUsuario} from '@app/core/enums';

export const redirectGuard: CanActivateFn = (): UrlTree => {
  const auth = inject(AuthState);
  const router = inject(Router);

  const user = auth.currentUser();

  if (!user) {
    return router.createUrlTree(['/login']);
  }

  switch (user.tipoUsuario) {
    case TipoUsuario.alumno:
      return router.createUrlTree(['/alumno']);
    case TipoUsuario.docente:
      return router.createUrlTree(['/docente']);
    case TipoUsuario.gestion:
      return router.createUrlTree(['/gestion']);
    default:
      return router.createUrlTree(['/login']);
  }
};
