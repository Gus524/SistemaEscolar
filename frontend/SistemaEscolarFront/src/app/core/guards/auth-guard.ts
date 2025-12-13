import {CanMatchFn, Router} from '@angular/router';
import {AuthState} from '@app/core/services/auth';
import {inject} from '@angular/core';

export const authGuard: CanMatchFn = (route, segments) => {
  const auth = inject(AuthState);

  if (auth.isActive()){
    return true;
  }

  return auth.accessDenied();
};
