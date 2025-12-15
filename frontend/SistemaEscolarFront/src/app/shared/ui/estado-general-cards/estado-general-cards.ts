import {Component, computed, input} from '@angular/core';
import {EstadoGeneral} from '@app/core/models/historial-academico';

@Component({
  selector: 'app-estado-general-cards',
  imports: [],
  template: `
    <article class="status-card danger">
      <header>
        <h3>Materias desfasadas</h3>
        <span class="count-badge">{{ reprobadas().length }}</span>
      </header>
      <ul>
        @for (m of desfasadas(); track m.materia) {
          <li>
            <span class="materia-name">{{ m.materia }}</span>
            <small class="academia-text">{{ m.academia }}</small>
          </li>
        } @empty {
          <li class="empty-msg">Vas al corriente con tu plan de estudios.</li>
        }
      </ul>
    </article>

    <article class="status-card warning">
      <header>
        <h3>Materias reprobadas</h3>
        <span class="count-badge">{{ desfasadas().length }}</span>
      </header>

      <ul>
        @for (m of reprobadas(); track m.materia) {
          <li>
            <span class="materia-name">{{ m.materia }}</span>
            <small class="academia-text">{{ m.academia }}</small>
          </li>
        } @empty {
          <li class="empty-msg">No tienes materias reprobadas. ¡Bien hecho!</li>
        }
      </ul>
    </article>

    <article class="status-card neutral">
      <header>
        <h3>Materias no cursadas</h3>
        <span class="count-badge">{{ noCursadas().length }}</span>
      </header>

      <ul>
        @for (m of noCursadas(); track m.materia) {
          <li>
            <span class="materia-name">{{ m.materia }}</span>
            <small class="academia-text">{{ m.academia }}</small>
          </li>
        } @empty {
          <li class="empty-msg">Has cursado todas las materias disponibles.</li>
        }
      </ul>
    </article>
  `,
  styles: [`
    :host {
      display: grid;
      grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
      gap: 1.5rem;
      width: 100%;
    }

    .status-card {
      background-color: var(--color-bg-card, #fff);
      border-radius: var(--radius-md, 8px);
      box-shadow: var(--shadow-sm, 0 2px 4px rgba(0,0,0,0.05));
      border: 1px solid var(--color-border, #eee);
      overflow: hidden;
      display: flex;
      flex-direction: column;

      &.danger {
        border-top: 4px solid var(--color-danger, #e74c3c);
        header { color: var(--color-danger, #e74c3c); }
      }

      &.warning {
        border-top: 4px solid var(--color-warning, #f1c40f);
        header { color: var(--color-warning-dark, #b7950b); }
      }

      &.neutral {
        border-top: 4px solid var(--color-secondary, #95a5a6);
        header { color: var(--color-secondary-dark, #7f8c8d); }
      }

      header {
        padding: 1rem;
        display: flex;
        justify-content: space-between;
        align-items: center;
        background-color: rgba(0,0,0,0.02);
        border-bottom: 1px solid rgba(0,0,0,0.05);

        h3 {
          margin: 0;
          font-size: 1.1rem;
          font-weight: 700;
        }

        .count-badge {
          background-color: rgba(0,0,0,0.1);
          padding: 0.2rem 0.6rem;
          border-radius: 1rem;
          font-size: 0.85rem;
          font-weight: 700;
        }
      }

      ul {
        list-style: none;
        margin: 0;
        padding: 0;
        flex: 1;
        max-height: 360px;
        overflow-y: auto;

        li {
          padding: 0.8rem 1rem;
          border-bottom: 1px solid rgba(0,0,0,0.03);
          display: flex;
          flex-direction: column;

          &:last-child { border-bottom: none; }

          .materia-name {
            font-weight: 600;
            color: var(--color-text-main, #2c3e50);
          }

          .academia-text {
            color: var(--color-text-muted, #7f8c8d);
            font-size: 0.85rem;
          }

          &.empty-msg {
            padding: 2rem 1rem;
            text-align: center;
            color: var(--color-text-muted, #999);
            font-style: italic;
          }
        }
      }
    }
  `]
})
export class EstadoGeneralCards {
  materias = input.required<EstadoGeneral[]>();

  reprobadas = computed(() =>
    this.materias().filter(m => m.estado === 'REPROBADA')
  );

  desfasadas = computed(() =>
    this.materias().filter(m => m.estado === 'DESFASADA')
  );

  noCursadas = computed(() =>
    this.materias().filter(m => m.estado === 'NO CURSADA')
  );
}
