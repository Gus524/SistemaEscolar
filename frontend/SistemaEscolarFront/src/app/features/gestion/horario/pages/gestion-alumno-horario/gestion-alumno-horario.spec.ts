import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GestionAlumnoHorario } from './gestion-alumno-horario';

describe('GestionAlumnoHorario', () => {
  let component: GestionAlumnoHorario;
  let fixture: ComponentFixture<GestionAlumnoHorario>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [GestionAlumnoHorario]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GestionAlumnoHorario);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
