import {Component, inject} from '@angular/core';
import {Navbar} from '@app/core/layout/navbar/navbar';
import {MenuState} from '@app/core/services/ui/menu-state';
import {RouterOutlet} from '@angular/router';

@Component({
  selector: 'app-main-layout',
  imports: [
    Navbar,
    RouterOutlet
  ],
  template: `
    <app-navbar [items]="menuState.menuItems()" />

    <main class="layout-content">
      <router-outlet />
    </main>

    <footer class="layout-footer">
      <p>&copy; {{ currentYear }} School Shield. Todos los derechos reservados.</p>
    </footer>
  `,
  styleUrls: ['./main-layout.scss']
})
export class MainLayout {
  protected menuState = inject(MenuState);
  protected currentYear = new Date().getFullYear();
}
