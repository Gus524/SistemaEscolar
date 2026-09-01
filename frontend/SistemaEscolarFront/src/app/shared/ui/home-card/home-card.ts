import { Component, input } from '@angular/core';

@Component({
  selector: 'app-home-card',
  imports: [],
  template: `
    <article class="home-layout">
      <header class="brand-header">
        <h1 class="school-name">{{ instituto() }}</h1>
        <hr>
        <p class="welcome-text">¡Bienvenido!</p>
      </header>
      <article class="user-data">
        <ng-content></ng-content>
      </article>
    </article>
  `,
  styles: [`
    :host ::ng-deep .details-text {
      font-size: 1.5rem;
      line-height: 1.6;
    }

    .home-layout {
      width: 100%;
    }

    .brand-header {
      text-align: center;
      margin-bottom: 4rem;
    }

    .school-name {
      font-size: 2rem;
      font-weight: 500;
      color: var(--color-primary-900);
      margin-bottom: 1rem;
      line-height: 1.4;
    }

    .welcome-text {
      margin-top: 1rem;
      font-size: 1.8rem;
      color: var(--color-primary-900);
      font-weight: 300;
    }

    .user-data {
      display: flex;
      justify-content: space-around;
    }
  `]
})
export class HomeCard {
  instituto = input.required<string>();
}
