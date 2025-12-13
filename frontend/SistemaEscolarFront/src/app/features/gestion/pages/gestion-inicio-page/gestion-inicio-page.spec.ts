import {ComponentFixture, DeferBlockState, TestBed} from '@angular/core/testing';
import {GestionInicioPage} from './gestion-inicio-page';
import {InicioState} from '@app/core/services/inicio/inicio-state';
import {By} from '@angular/platform-browser';
import {beforeEach, describe, expect, it} from 'vitest';
import {provideZonelessChangeDetection, signal} from '@angular/core';

describe('GestionInicioPage', () => {
  let fixture: ComponentFixture<GestionInicioPage>;

  const mockData = signal({ institucion: 'Rectoría' });
  const stateMock = { rawData: mockData };

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [GestionInicioPage],
      providers: [
        { provide: InicioState, useValue: stateMock },
        provideZonelessChangeDetection()
      ]
    }).compileComponents();

    fixture = TestBed.createComponent(GestionInicioPage);
    fixture.detectChanges();
  });

  it('debe mostrar el texto estático de "Gestion Escolar"', async () => {
    fixture.detectChanges();

    const deferBlock = (await fixture.getDeferBlocks())[0];

    if (deferBlock) {
      await deferBlock.render(DeferBlockState.Complete);
    }

    const details = fixture.debugElement.query(By.css('.details-text'));
    const homeCard = fixture.debugElement.query(By.css('app-home-card'));

    expect(homeCard.componentInstance.instituto()).toBe('Rectoría');

    expect(details.nativeElement.textContent).toContain('Usuario:');
    expect(details.nativeElement.textContent).toContain('Gestion Escolar');
  });
});
