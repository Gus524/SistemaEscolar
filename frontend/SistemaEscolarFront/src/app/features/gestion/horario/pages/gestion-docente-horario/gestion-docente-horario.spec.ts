import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GestionDocenteHorario } from './gestion-docente-horario';

describe('GestionDocenteHorario', () => {
  let component: GestionDocenteHorario;
  let fixture: ComponentFixture<GestionDocenteHorario>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [GestionDocenteHorario]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GestionDocenteHorario);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
