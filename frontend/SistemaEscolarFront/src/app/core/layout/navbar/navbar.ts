import {Component, computed, inject, input, signal} from '@angular/core';
import {RouterLink, RouterLinkActive} from '@angular/router';
import {NgOptimizedImage} from '@angular/common';
import {AuthState} from '@app/core/services/auth';
import {MenuItem} from '@app/core/models/menu';
import {TipoUsuario} from '@app/core/enums';

@Component({
  selector: 'app-navbar',
  imports: [
    RouterLink,
    RouterLinkActive,
    NgOptimizedImage
  ],
  template: `
    <header class="main-header">
      <nav class="navbar">
        <a class="brand" routerLink="/">
          <img ngSrc="/assets/img/logo/logo-nuevo.png" alt="Logotipo School Shield" width="60" height="60">
          <span class="brand-name">School Shield</span>
        </a>

        <button class="mobile-toggle" (click)="toggleMenu()" aria-label="Abrir menú">
          <span class="material-symbols-rounded">menu</span>
        </button>

        <ul class="nav-list" [class.is-open]="isMenuOpen()">

          @for (item of items(); track item.label) {
            <li class="nav-item">

              @if (item.children) {
                <button class="nav-link dropdown-trigger" (click)="toggleDropdown(item.label)">
                  @if (item.icon) {
                    <span class="material-symbols-rounded icon">{{ item.icon }}</span>
                  }
                  {{ item.label }}
                  <span class="material-symbols-rounded arrow" [class.rotate]="activeDropdown() === item.label">expand_more</span>
                </button>

                @if (activeDropdown() === item.label) {
                  <ul class="dropdown-menu">
                    @for (sub of item.children; track sub.label) {
                      <li>
                        <a [routerLink]="sub.route" routerLinkActive="active" class="dropdown-item" (click)="closeMenu()">
                          @if (sub.icon) {
                            <span class="material-symbols-rounded icon-sm">{{ sub.icon }}</span>
                          }
                          {{ sub.label }}
                        </a>
                      </li>
                    }
                  </ul>
                }

              } @else {
                <a [routerLink]="item.route" routerLinkActive="active" class="nav-link">
                  @if (item.icon) {
                    <span class="material-symbols-rounded icon">{{ item.icon }}</span>
                  }
                  {{ item.label }}
                </a>
              }
            </li>
          }

          <li class="nav-item user-menu-container">
            <button
              class="nav-link dropdown-trigger user-trigger"
              (click)="toggleDropdown('USER_MENU')"
              [class.active]="activeDropdown() === 'USER_MENU'">

              <span class="material-symbols-rounded icon">account_circle</span>
              <span class="material-symbols-rounded arrow" [class.rotate]="activeDropdown() === 'USER_MENU'">expand_more</span>
            </button>

            @if (activeDropdown() === 'USER_MENU') {
              <ul class="dropdown-menu user-dropdown">
                @if (profileRoute(); as route) {
                  <li>
                    <a [routerLink]="route" class="dropdown-item" (click)="closeMenu()">
                      <span class="material-symbols-rounded icon-sm">person</span>
                      Datos Personales
                    </a>
                  </li>
                  <li class="divider"></li>
                }

                <li>
                  <button (click)="auth.logout()" class="dropdown-item danger">
                    <span class="material-symbols-rounded icon-sm">logout</span>
                    Cerrar Sesión
                  </button>
                </li>
              </ul>
            }
          </li>

        </ul>
      </nav>
    </header>
  `,
  styleUrl: './navbar.scss'
})
export class Navbar {
  protected auth = inject(AuthState);
  items = input.required<MenuItem[]>();

  isMenuOpen = signal(false);
  activeDropdown = signal<string | null>(null);

  profileRoute = computed(() => {
    const user = this.auth.currentUser();

    if (!user) return null;

    switch (user.tipoUsuario) {
      case TipoUsuario.alumno:
        return '/alumno/datos-personales';
      case TipoUsuario.docente:
        return '/docente/datos-personales';
      default:
        return null;
    }
  });

  toggleMenu() {
    this.isMenuOpen.update(v => !v);
  }

  toggleDropdown(label: string) {
    this.activeDropdown.update(current => current === label ? null : label);
  }

  closeMenu() {
    this.isMenuOpen.set(false);
    this.activeDropdown.set(null);
  }
}
