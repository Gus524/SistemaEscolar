import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GestionDocentesPage } from './gestion-docentes-page';

describe('GestionDocentesPage', () => {
  let component: GestionDocentesPage;
  let fixture: ComponentFixture<GestionDocentesPage>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [GestionDocentesPage]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GestionDocentesPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
