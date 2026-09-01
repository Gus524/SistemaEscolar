import {HttpContext, HttpContextToken} from '@angular/common/http';

export const BYPASS_AUTH = new HttpContextToken<boolean>(() => false);
export function publicContext() {
  return new HttpContext()
  .set(BYPASS_AUTH, true);
}
