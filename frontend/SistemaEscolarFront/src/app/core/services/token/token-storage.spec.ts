import { TestBed } from '@angular/core/testing';
import { TokenStorage } from './token-storage';
import {PLATFORM_ID, provideZonelessChangeDetection} from '@angular/core';
import { describe, it, expect, beforeEach, afterEach, vi } from 'vitest';

describe('TokenStorage Service', () => {
  let service: TokenStorage;
  let localStorageMock: any;

  beforeEach(() => {
    localStorageMock = {
      getItem: vi.fn(),
      setItem: vi.fn(),
      removeItem: vi.fn(),
      clear: vi.fn()
    };

    vi.stubGlobal('localStorage', localStorageMock);
  });

  afterEach(() => {
    vi.clearAllMocks();
    vi.unstubAllGlobals();
  });

  describe('Browser Environment', () => {
    beforeEach(() => {
      TestBed.configureTestingModule({
        providers: [
          TokenStorage,
          { provide: PLATFORM_ID, useValue: 'browser' },
          provideZonelessChangeDetection()
        ]
      });
      service = TestBed.inject(TokenStorage);
    });

    it('saveToken() debe llamar a localStorage.setItem', () => {
      const token = '12345';
      service.saveToken(token);

      expect(localStorageMock.setItem).toHaveBeenCalledWith('auth-token', token);
    });

    it('getToken() debe retornar el valor de localStorage.getItem', () => {
      localStorageMock.getItem.mockReturnValue('stored-token');

      const result = service.getToken();

      expect(localStorageMock.getItem).toHaveBeenCalledWith('auth-token');
      expect(result).toBe('stored-token');
    });

    it('removeToken() debe llamar a localStorage.removeItem', () => {
      service.removeToken();

      expect(localStorageMock.removeItem).toHaveBeenCalledWith('auth-token');
    });
  });

  describe('Server Environment', () => {
    beforeEach(() => {
      TestBed.configureTestingModule({
        providers: [
          TokenStorage,
          { provide: PLATFORM_ID, useValue: 'server' },
          provideZonelessChangeDetection()
        ]
      });
      service = TestBed.inject(TokenStorage);
    });

    it('saveToken() NO debe hacer nada (no llamar a setItem)', () => {
      service.saveToken('token');
      expect(localStorageMock.setItem).not.toHaveBeenCalled();
    });

    it('getToken() debe retornar null y NO llamar a getItem', () => {
      localStorageMock.getItem.mockReturnValue('token-fantasma');

      const result = service.getToken();

      expect(localStorageMock.getItem).not.toHaveBeenCalled();
      expect(result).toBeNull();
    });

    it('removeToken() NO debe hacer nada (no llamar a removeItem)', () => {
      service.removeToken();
      expect(localStorageMock.removeItem).not.toHaveBeenCalled();
    });
  });
});
