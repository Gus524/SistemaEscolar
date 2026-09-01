import { Component } from '@angular/core';
import {NgOptimizedImage} from '@angular/common';

@Component({
  selector: 'app-loader',
  imports: [
    NgOptimizedImage
  ],
  template: `
    <div class="app-splash-screen">
      <figure class="logo-container">
        <img
          ngSrc="/assets/img/logo/logo-header.png"
          alt="Cargando..."
          width="100"
          height="100"
          priority
        >
      </figure>
      <p class="loading-text">Cargando<span>.</span><span>.</span><span>.</span></p>
    </div>
  `,
  styleUrl: './loader.scss'
})
export class Loader {}
