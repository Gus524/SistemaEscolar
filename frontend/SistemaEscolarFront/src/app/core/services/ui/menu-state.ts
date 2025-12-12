import {computed, inject, Injectable} from '@angular/core';
import {AuthState} from '@app/core/services/auth/auth-state';
import {MenuItem} from '@app/core/models';
import {MENU_CONFIG} from '@app/core/config/menu.config';

@Injectable({
  providedIn: 'root'
})
export class MenuState {
  private auth = inject(AuthState);

  readonly menuItems = computed<MenuItem[]>(() => {
    const user = this.auth.currentUser();

    if (!user) return [];

    const roleConfig = MENU_CONFIG[user.tipoUsuario];

    return roleConfig || [];
  })
}
