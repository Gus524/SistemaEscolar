import { ComponentFixture, TestBed } from '@angular/core/testing';
import { AlumnoInicioPage } from './alumno-inicio-page';
import { AuthState } from '@app/core/services/auth';
import { InicioState } from '@app/core/services/inicio/inicio-state';
import { By } from '@angular/platform-browser';
import { describe, it, expect, beforeEach, vi } from 'vitest';
import {provideZonelessChangeDetection, signal} from '@angular/core';
import { DeferBlockState } from '@angular/core/testing';

describe('AlumnoInicioPage', () => {
  let fixture: ComponentFixture<AlumnoInicioPage>;

  const mockUser = signal({ nombre: 'Eric Gustavo' });
  const mockData = signal({ institucion: 'UPIICSA', carrera: 'Ingeniería' });

  const authMock = { currentUser: mockUser };
  const stateMock = { as: vi.fn().mockReturnValue(mockData) };

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AlumnoInicioPage],
      providers: [
        { provide: AuthState, useValue: authMock },
        { provide: InicioState, useValue: stateMock },
        provideZonelessChangeDetection()
      ]
    }).compileComponents();

    fixture = TestBed.createComponent(AlumnoInicioPage);
    fixture.detectChanges();
  });

  it('debe mostrar la información del alumno correctamente', async () => {
    fixture.detectChanges();

    const deferBlock = (await fixture.getDeferBlocks())[0];
    if (deferBlock) {
      await deferBlock.render(DeferBlockState.Complete);
    }

    const homeCard = fixture.debugElement.query(By.css('app-home-card'));
    const details = fixture.debugElement.queryAll(By.css('.details-text'));

    expect(homeCard).toBeTruthy();
    expect(homeCard.componentInstance.instituto()).toBe('UPIICSA');

    expect(details.length).toBeGreaterThan(1);
    expect(details[0].nativeElement.textContent).toContain('Nombre: ');
    expect(details[1].nativeElement.textContent).toContain('Ingeniería');
  });
});
