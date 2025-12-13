import { ComponentFixture, TestBed } from '@angular/core/testing';
import { provideRouter } from '@angular/router';
import { By } from '@angular/platform-browser';
import { Navbar } from './navbar';
import { MenuItem } from '@app/core/models';
import { describe, it, expect, beforeEach } from 'vitest';
import {provideZonelessChangeDetection} from '@angular/core';

const MOCK_MENU_ITEMS: MenuItem[] = [
  {
    label: 'Alumnos',
    route: '/gestion/alumnos',
    icon: 'face'
  },
  {
    label: 'Inscripción',
    icon: 'how_to_reg',
    children: [
      { label: 'Comprobante', route: '/alumno/comprobante', icon: 'receipt_long' },
      { label: 'Calificaciones', route: '/alumno/calificaciones', icon: 'grade' }
    ]
  },
  {
    label: 'Horarios',
    icon: 'schedule',
    children: [
      { label: 'Ocupabilidad', route: '/common/ocupabilidad' }
    ]
  }
];

describe('Navbar Component', () => {
  let component: Navbar;
  let fixture: ComponentFixture<Navbar>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Navbar],
      providers: [
        provideRouter([]),
        provideZonelessChangeDetection()
      ]
    }).compileComponents();

    fixture = TestBed.createComponent(Navbar);
    component = fixture.componentInstance;

    fixture.componentRef.setInput('items', MOCK_MENU_ITEMS);
    fixture.detectChanges(); // Renderizado inicial
  });

  it('debe crearse correctamente', () => {
    expect(component).toBeTruthy();
  });

  describe('Renderizado Inicial', () => {
    it('debe renderizar items simples y botones dropdown', () => {
      const navItems = fixture.debugElement.queryAll(By.css('.nav-list > .nav-item'));
      const simpleLink = fixture.debugElement.query(By.css('a.nav-link'));
      const dropdownBtns = fixture.debugElement.queryAll(By.css('button.dropdown-trigger'));

      expect(navItems.length).toBe(4);

      expect(simpleLink).toBeTruthy();
      expect(simpleLink.nativeElement.textContent).toContain('Alumnos');

      expect(dropdownBtns.length).toBe(2);
      expect(dropdownBtns[0].nativeElement.textContent).toContain('Inscripción');
    });
  });

  describe('Interacción: Menú Móvil', () => {
    it('debe alternar la visibilidad del menú al hacer click en el toggle', () => {
      const navList = fixture.debugElement.query(By.css('.nav-list'));
      const toggleBtn = fixture.debugElement.query(By.css('.mobile-toggle'));

      expect(component.isMenuOpen()).toBe(false);
      expect(navList.classes['is-open']).toBeFalsy();

      toggleBtn.nativeElement.click();
      fixture.detectChanges();

      expect(component.isMenuOpen()).toBe(true);
      expect(navList.classes['is-open']).toBe(true);

      toggleBtn.nativeElement.click();
      fixture.detectChanges();

      expect(component.isMenuOpen()).toBe(false);
      expect(navList.classes['is-open']).toBeFalsy();
    });
  });

  describe('Interacción: Dropdowns', () => {
    it('debe mostrar el submenú (DOM) al hacer click en el trigger', () => {
      const inscriptionTrigger = fixture.debugElement.queryAll(By.css('.dropdown-trigger'))[0];

      inscriptionTrigger.nativeElement.click();
      fixture.detectChanges();

      expect(component.activeDropdown()).toBe('Inscripción');

      const dropdownMenu = fixture.debugElement.query(By.css('.dropdown-menu'));
      expect(dropdownMenu).toBeTruthy();

      expect(dropdownMenu.nativeElement.textContent).toContain('Comprobante');
    });

    it('debe cerrar un dropdown si se hace click nuevamente en él (Toggle)', () => {
      component.activeDropdown.set('Inscripción');
      fixture.detectChanges();

      const inscriptionTrigger = fixture.debugElement.queryAll(By.css('.dropdown-trigger'))[0];
      expect(fixture.debugElement.query(By.css('.dropdown-menu'))).toBeTruthy();

      inscriptionTrigger.nativeElement.click();
      fixture.detectChanges();

      expect(component.activeDropdown()).toBeNull();
      const dropdownMenu = fixture.debugElement.query(By.css('.dropdown-menu'));
      expect(dropdownMenu).toBeNull();
    });

    it('debe cerrar el dropdown A cuando se abre el dropdown B (Exclusividad)', () => {
      const triggers = fixture.debugElement.queryAll(By.css('.dropdown-trigger'));
      const inscriptionTrigger = triggers[0];
      const schedulesTrigger = triggers[1];

      inscriptionTrigger.nativeElement.click();
      fixture.detectChanges();
      expect(component.activeDropdown()).toBe('Inscripción');
      expect(fixture.debugElement.query(By.css('.dropdown-menu')).nativeElement.textContent).toContain('Comprobante');

      schedulesTrigger.nativeElement.click();
      fixture.detectChanges();

      expect(component.activeDropdown()).toBe('Horarios');

      const dropdownMenu = fixture.debugElement.query(By.css('.dropdown-menu'));
      expect(dropdownMenu.nativeElement.textContent).toContain('Ocupabilidad');
      expect(dropdownMenu.nativeElement.textContent).not.toContain('Comprobante');
    });
  });
});
