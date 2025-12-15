import {Component, provideZonelessChangeDetection} from '@angular/core';
import { ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { HomeCard } from './home-card';
import { describe, it, expect, beforeEach } from 'vitest';

@Component({
  template: `
    <app-home-card [instituto]="testInstitute">
      <div class="test-content">Contenido Proyectado</div>
    </app-home-card>
  `,
  imports: [HomeCard]
})
class TestHostComponent {
  testInstitute = 'Instituto Politécnico Nacional';
}

describe('HomeCard Component', () => {
  let fixture: ComponentFixture<TestHostComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TestHostComponent],
      providers: [
        provideZonelessChangeDetection()
      ]
    }).compileComponents();

    fixture = TestBed.createComponent(TestHostComponent);
    fixture.detectChanges();
  });

  it('debe renderizar el nombre del instituto pasado por input', () => {
    const titleElement = fixture.debugElement.query(By.css('.school-name'));
    expect(titleElement.nativeElement.textContent).toContain('Instituto Politécnico Nacional');
  });

  it('debe proyectar el contenido HTML dentro de user-data', () => {
    const projectedContent = fixture.debugElement.query(By.css('.user-data .test-content'));

    expect(projectedContent).toBeTruthy();
    expect(projectedContent.nativeElement.textContent).toBe('Contenido Proyectado');
  });

  it('debe mostrar el mensaje de bienvenida estático', () => {
    const welcomeText = fixture.debugElement.query(By.css('.welcome-text'));

    expect(welcomeText.nativeElement.textContent).toContain('¡Bienvenido!');
  });
});
