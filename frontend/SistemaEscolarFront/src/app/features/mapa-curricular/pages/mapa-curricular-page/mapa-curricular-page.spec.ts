import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MapaCurricularPage } from './mapa-curricular-page';

describe('MapaCurricularPage', () => {
  let component: MapaCurricularPage;
  let fixture: ComponentFixture<MapaCurricularPage>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MapaCurricularPage]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MapaCurricularPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
