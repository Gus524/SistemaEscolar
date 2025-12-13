import { TestBed } from '@angular/core/testing';
import { InicioState } from './inicio-state';
import { InicioApi } from '@app/core/services/inicio/inicio-api';
import { of } from 'rxjs';
import { describe, it, expect, beforeEach, vi } from 'vitest';
import {AlumnoInicio} from '@app/features/alumno/inicio/models/alumno-inicio.model';
import {provideZonelessChangeDetection} from '@angular/core';

describe('InicioState Service', () => {
  let service: InicioState;
  let apiSpy: any;

  const mockData: AlumnoInicio = {
    idInstitucion: 1,
    institucion: 'UPIICSA',
    idPlan: 10,
    carrera: 'Ingeniería Informática',
    nombre: 'Alumno'
  };

  beforeEach(() => {
    apiSpy = {
      getInicio: vi.fn().mockReturnValue(of(mockData))
    };

    TestBed.configureTestingModule({
      providers: [
        InicioState,
        { provide: InicioApi, useValue: apiSpy },
        provideZonelessChangeDetection()
      ]
    });

    service = TestBed.inject(InicioState);
  });

  it('debe llamar a la API al inicializarse', () => {
    expect(apiSpy.getInicio).toHaveBeenCalledTimes(1);
  });

  it('debe actualizar rawData con la respuesta de la API', () => {
    const data = service.rawData();

    expect(data).toEqual(mockData);
    expect(service.loading()).toBe(false);
  });

  it('debe permitir castear los datos con as<T>()', () => {
    const alumnoSignal = service.as<AlumnoInicio>();

    expect(alumnoSignal()?.carrera).toBe('Ingeniería Informática');
  });
});
