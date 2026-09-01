import {CanMatchFn, Router} from '@angular/router';
import {inject} from '@angular/core';
import {AuthState} from '@app/core/services/auth';

export const publicGuard: CanMatchFn = () => {
  const auth = inject(AuthState);
  const router = inject(Router);

  if (auth.isActive()){
    return router.createUrlTree(['/']);
  }

  return true;
};
