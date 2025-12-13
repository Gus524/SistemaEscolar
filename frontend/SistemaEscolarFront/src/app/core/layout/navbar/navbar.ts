import {Component, input, signal} from '@angular/core';
import {RouterLink, RouterLinkActive} from '@angular/router';
import {NgOptimizedImage} from '@angular/common';
import {MenuItem} from '@app/core/models';

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
          <img ngSrc="/assets/img/logo/logo_p.png" alt="Logotipo Sistema Escolar" width="50" height="45">
          <span class="brand-name">Sistema Escolar</span>
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
                        <a [routerLink]="sub.route" routerLinkActive="active" class="dropdown-item">
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

          <li class="nav-item user-actions">
            <a routerLink="/profile" class="nav-link profile-link">
              <span class="material-symbols-rounded icon">account_circle</span>
            </a>
            <a routerLink="/auth/logout" class="nav-link logout-link" title="Cerrar sesión">
              <span class="material-symbols-rounded icon">logout</span>
            </a>
          </li>

        </ul>
      </nav>
    </header>
  `,
  styleUrl: './navbar.scss'
})
export class Navbar {
  items = input.required<MenuItem[]>();

  isMenuOpen = signal(false);
  activeDropdown = signal<string | null>(null);

  toggleMenu() {
    this.isMenuOpen.update(v => !v);
  }

  toggleDropdown(label: string) {
    this.activeDropdown.update(current => current === label ? null : label);
  }
}
