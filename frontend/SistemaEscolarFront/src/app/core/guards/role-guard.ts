import {CanMatchFn, Route, Router, UrlSegment, UrlTree} from '@angular/router';
import {TipoUsuario} from '@app/core/enums';
import {inject} from '@angular/core';
import {AuthState} from '@app/core/services/auth';

export const roleGuard = (allowedRoles: TipoUsuario[]): CanMatchFn => {
  return (route: Route, segments: UrlSegment[]): boolean | UrlTree => {
    const auth = inject(AuthState);

    const user = auth.currentUser();

    if (!user || !auth.isActive()) {
      return auth.accessDenied();
    }

    if (allowedRoles.includes(user.tipoUsuario)) {
      return true;
    }

    return auth.forbidden();
  };
};
