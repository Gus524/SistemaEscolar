import {Component, input} from '@angular/core';

@Component({
  selector: 'app-datos-docente',
  imports: [],
  template: `
    <article class="datos-container">
      <header class="datos-header">
        <h2 class="section-title">{{ titulo() }}</h2>
        <hgroup class="info-row">
          <p class="datos-text">
            <strong>Academia: </strong>
            {{ academia() }}
          </p>
          <p class="datos-text">
            <strong>Nombre: </strong>
            {{ nombre() }}
          </p>
        </hgroup>
      </header>
    </article>
    <hr class="custom-hr">
  `
})
export class DatosDocente {
  academia = input.required<string>();
  nombre = input.required<string>();
  titulo = input.required<string>();
}
