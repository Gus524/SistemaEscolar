import { TestBed } from '@angular/core/testing';

import { MapaCurricularState } from './mapa-curricular-state';

describe('MapaCurricularState', () => {
  let service: MapaCurricularState;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MapaCurricularState);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
