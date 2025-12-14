import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CarreraPlanSelector } from './carrera-plan-selector';

describe('CarreraPlanSelector', () => {
  let component: CarreraPlanSelector;
  let fixture: ComponentFixture<CarreraPlanSelector>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CarreraPlanSelector]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CarreraPlanSelector);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
