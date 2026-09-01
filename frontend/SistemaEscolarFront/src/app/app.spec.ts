import { provideZonelessChangeDetection } from '@angular/core';
import { describe, beforeEach, it, expect } from 'vitest';
import {ComponentFixture, TestBed} from '@angular/core/testing';
import { App } from './app';
import {provideRouter, RouterOutlet} from '@angular/router';
import {By} from '@angular/platform-browser';

describe('App Component', () => {
  let component: App;
  let fixture: ComponentFixture<App>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [App],
      providers: [
        provideRouter([]),
        provideZonelessChangeDetection()
      ]
    }).compileComponents();

    fixture = TestBed.createComponent(App);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('debe crearse correctamente la aplicación', () => {
    expect(component).toBeTruthy();
  });

  describe('Estructura del Template', () => {
    it('debe contener el RouterOutlet para manejar la navegación', () => {
      const outlet = fixture.debugElement.query(By.directive(RouterOutlet));
      expect(outlet).toBeTruthy();
    });
  });
});
