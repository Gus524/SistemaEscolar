import {Component, inject} from '@angular/core';
import {RouterLink} from '@angular/router';
import {Location} from '@angular/common';

@Component({
  selector: 'app-forbidden-page',
  imports: [
    RouterLink
  ],
  template: `
    <article class="error-container">
      <h1>403</h1>
      <h2>Acceso restringido</h2>
      <p>No tienes permisos para ver esta sección.</p>

      <div class="actions">
        <button (click)="location.back()">Regresar</button>
        <a routerLink="/" class="btn-primary">Ir al inicio</a>
      </div>
    </article>
  `,
  styles: [`
    .error-container {
      height: 100vh;
      display: flex;
      flex-direction: column;
      align-items: center;
      justify-content: center;
      text-align: center;
      font-family: 'Montserrat', sans-serif;
    }
    h1 { font-size: 6rem; color: #d32f2f; margin: 0; }
    h2 { margin-bottom: 1rem; }
    .actions { display: flex; gap: 1rem; margin-top: 2rem; }
    button, a { padding: 0.8rem 1.5rem; cursor: pointer; }
  `]
})
export class ForbiddenPage {
  location = inject(Location);
}
