import {Component, inject, input} from '@angular/core';
import {Location} from '@angular/common';

@Component({
  selector: 'app-under-construction-page',
  imports: [],
  template: `
    <main class="construction-layout">
      <article class="content-card">
        <figure class="illustration-container">
          <svg viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg" class="construction-icon">
            <path d="M21.71 11.29l-9-9c-.39-.39-1.02-.39-1.41 0l-9 9c-.39.39-.39 1.02 0 1.41l9 9c.39.39 1.02.39 1.41 0l9-9c.39-.38.39-1.01 0-1.41zM14 14.5V12h-4v3H8v-4c0-.55.45-1 1-1h5V7.5l3.5 3.5-3.5 3.5z" fill="currentColor"/>
          </svg>
        </figure>

        <h1 class="title">{{ title() }}</h1>
        <p class="message">{{ message() }}</p>

        <div class="actions">
          <button class="btn-primary" (click)="goBack()">
            <span class="material-symbols-rounded">arrow_back</span>
            Regresar
          </button>
        </div>
      </article>
    </main>
  `,
  styleUrl: 'under-construction-page.scss'
})
export class UnderConstructionPage {
  location = inject(Location);
  title = input('Funcionalidad en Desarrollo');
  message = input('Estamos trabajando arduamente para traerte esta funcionalidad pronto. Agradecemos tu paciencia.');

  goBack() {
    this.location.back();
  }
}
