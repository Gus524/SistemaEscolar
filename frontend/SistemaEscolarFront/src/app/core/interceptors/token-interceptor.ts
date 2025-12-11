import { HttpInterceptorFn } from '@angular/common/http';
import {BYPASS_AUTH} from '@app/core/contexts/public.context';
import {inject} from '@angular/core';
import {AuthState} from '@app/core/services/auth-state';

export const tokenInterceptor: HttpInterceptorFn = (req, next) => {
  if (req.context.get(BYPASS_AUTH)) {
    return next(req);
  }

  const auth = inject(AuthState);
  const token = auth.token();

  if (!token) {

  }

  const clonReq = req.clone({
    headers: req.headers.set('Authorization', `Bearer  ${token}` ),
  });

  return next(clonReq);
};
