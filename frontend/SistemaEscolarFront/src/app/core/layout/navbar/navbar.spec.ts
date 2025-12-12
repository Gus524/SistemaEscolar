import { ComponentFixture, TestBed } from '@angular/core/testing';
import { provideRouter } from '@angular/router';
import { By } from '@angular/platform-browser';
import { Navbar } from './navbar';
import { MenuItem } from '@app/core/models';
import { describe, it, expect, beforeEach } from 'vitest';
import {provideZonelessChangeDetection} from '@angular/core';

const MOCK_MENU_ITEMS: MenuItem[] = [
  { label: 'Inicio', route: '/home', icon: 'home' },
  {
    label: 'Gestión',
    children: [
      { label: 'Usuarios', route: '/users', icon: 'group' },
      { label: 'Roles', route: '/roles', icon: 'lock' }
    ]
  },
  {
    label: 'Reportes',
    children: [
      { label: 'Financiero', route: '/finance' }
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
    fixture.detectChanges();
  });

  it('debe crearse correctamente', () => {
    expect(component).toBeTruthy();
  });

  describe('Renderizado del Menú', () => {
    it('debe renderizar los items de primer nivel correctamente', () => {
      const navItems = fixture.debugElement.queryAll(By.css('.nav-list > .nav-item'));

      expect(navItems.length).toBe(4);

      const firstLink = navItems[0].query(By.css('.nav-link'));
      expect(firstLink.nativeElement.textContent).toContain('Inicio');
    });

    it('debe renderizar botones dropdown para items con hijos', () => {
      const dropdownBtn = fixture.debugElement.query(By.css('button.dropdown-trigger'));
      expect(dropdownBtn).toBeTruthy();
      expect(dropdownBtn.nativeElement.textContent).toContain('Gestión');
    });
  });

  describe('Interacción: Menú Móvil', () => {
    it('debe alternar la clase "is-open" al hacer click en el toggle', () => {
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
    it('debe mostrar el submenú al hacer click en el trigger', () => {
      const triggers = fixture.debugElement.queryAll(By.css('.dropdown-trigger'));
      const gestionTrigger = triggers[0]; // El primero es Gestión

      gestionTrigger.nativeElement.click();
      fixture.detectChanges();

      expect(component.activeDropdown()).toBe('Gestión');

      const dropdownMenu = fixture.debugElement.query(By.css('.dropdown-ui'));
      expect(dropdownMenu).toBeTruthy();
      expect(dropdownMenu.nativeElement.textContent).toContain('Usuarios');
    });

    it('debe cerrar un dropdown si se hace click nuevamente en él', () => {
      component.activeDropdown.set('Gestión');
      fixture.detectChanges();

      const gestionTrigger = fixture.debugElement.query(By.css('.dropdown-trigger'));

      gestionTrigger.nativeElement.click();
      fixture.detectChanges();

      expect(component.activeDropdown()).toBeNull();
      const dropdownMenu = fixture.debugElement.query(By.css('.dropdown-ui'));
      expect(dropdownMenu).toBeNull();
    });

    it('debe cerrar el dropdown A cuando se abre el dropdown B (Exclusividad)', () => {
      const triggers = fixture.debugElement.queryAll(By.css('.dropdown-trigger'));
      const gestionTrigger = triggers[0];
      const reportesTrigger = triggers[1];

      gestionTrigger.nativeElement.click();
      fixture.detectChanges();
      expect(component.activeDropdown()).toBe('Gestión');

      reportesTrigger.nativeElement.click();
      fixture.detectChanges();

      expect(component.activeDropdown()).toBe('Reportes');

      const dropdownMenu = fixture.debugElement.query(By.css('.dropdown-ui'));
      expect(dropdownMenu.nativeElement.textContent).toContain('Financiero');
      expect(dropdownMenu.nativeElement.textContent).not.toContain('Usuarios');
    });
  });
});
