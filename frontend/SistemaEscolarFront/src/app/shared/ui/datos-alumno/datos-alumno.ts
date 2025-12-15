import {Component, input} from '@angular/core';

@Component({
  selector: 'app-datos-alumno',
  imports: [],
  template: `
    <article class="datos-container">
      <header class="datos-header">
        <h2 class="section-title">{{ titulo() }}</h2>
        <hgroup class="info-row">
          <p class="datos-text">
            <strong>Boleta: </strong>
            {{ boleta() }}
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
export class DatosAlumno {
  boleta = input.required<string>();
  nombre = input.required<string>();
  titulo = input.required<string>();
}
