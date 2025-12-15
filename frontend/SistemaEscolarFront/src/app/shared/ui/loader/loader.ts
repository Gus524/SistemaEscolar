import { Component } from '@angular/core';

@Component({
  selector: 'app-loader',
  imports: [],
  template: `
    <div class="app-splash-screen">
      <figure class="logo-container">
        <img
          ngSrc="assets/img/logo/logo_s.png"
          alt="Cargando..."
          width="180"
          height="180"
        >
      </figure>
      <p class="loading-text">Cargando<span>.</span><span>.</span><span>.</span></p>
    </div>
  `,
  styleUrl: './loader.scss'
})
export class Loader {}
