import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GestionAlumnosPage } from './gestion-alumnos-page';

describe('GestionAlumnosPage', () => {
  let component: GestionAlumnosPage;
  let fixture: ComponentFixture<GestionAlumnosPage>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [GestionAlumnosPage]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GestionAlumnosPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
