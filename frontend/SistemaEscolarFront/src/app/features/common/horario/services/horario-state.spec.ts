import { TestBed } from '@angular/core/testing';

import { HorarioState } from './horario-state';

describe('HorarioState', () => {
  let service: HorarioState;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(HorarioState);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
