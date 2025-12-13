import { ComponentFixture, TestBed } from '@angular/core/testing';
import { DocenteInicioPage } from './docente-inicio-page';
import { AuthState } from '@app/core/services/auth';
import { InicioState } from '@app/core/services/inicio/inicio-state';
import { By } from '@angular/platform-browser';
import { describe, it, expect, beforeEach, vi } from 'vitest';
import {provideZonelessChangeDetection, signal} from '@angular/core';
import { DeferBlockState } from '@angular/core/testing';

describe('DocenteInicioPage', () => {
  let fixture: ComponentFixture<DocenteInicioPage>;

  const mockUser = signal({ nombre: 'Profesor X' });
  const mockData = signal({ institucion: 'ESCOM', academia: 'Inteligencia Artificial', nombre: 'Profesor X' });

  const authMock = { currentUser: mockUser };
  const stateMock = { as: vi.fn().mockReturnValue(mockData) };

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DocenteInicioPage],
      providers: [
        { provide: AuthState, useValue: authMock },
        { provide: InicioState, useValue: stateMock },
        provideZonelessChangeDetection()
      ]
    }).compileComponents();

    fixture = TestBed.createComponent(DocenteInicioPage);
    fixture.detectChanges();
  });

  it('debe mostrar la academia del docente', async () => {
    fixture.detectChanges();

    const deferBlock = (await fixture.getDeferBlocks())[0];
    if (deferBlock) {
      await deferBlock.render(DeferBlockState.Complete);
    }

    const details = fixture.debugElement.queryAll(By.css('.details-text'));

    expect(details.length).toBeGreaterThan(1);

    expect(details[1].nativeElement.textContent).toContain('Academia:');
    expect(details[1].nativeElement.textContent).toContain('Inteligencia Artificial');
  });
});
