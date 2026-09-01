import { TestBed } from '@angular/core/testing';

import { CatalogoAcademicoState } from './catalogo-academico-state';

describe('CatalogoAcademicoState', () => {
  let service: CatalogoAcademicoState;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CatalogoAcademicoState);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
