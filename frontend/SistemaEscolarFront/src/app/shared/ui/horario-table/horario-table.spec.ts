import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HorarioTable } from './horario-table';

describe('HorarioTable', () => {
  let component: HorarioTable;
  let fixture: ComponentFixture<HorarioTable>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HorarioTable]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HorarioTable);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
