import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CurrentDocenteHeader } from './current-docente-header';

describe('CurrentDocenteHeader', () => {
  let component: CurrentDocenteHeader;
  let fixture: ComponentFixture<CurrentDocenteHeader>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CurrentDocenteHeader]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CurrentDocenteHeader);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
