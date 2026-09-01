import {signal} from '@angular/core';
import {finalize, Observable} from 'rxjs';
import {HttpErrorResponse} from '@angular/common/http';

export class AsyncState {
  private _loading = signal(false);
  private _error = signal<string | null>(null);

  readonly loading = this._loading.asReadonly();
  readonly error = this._error.asReadonly();

  execute<T>(
    source$: Observable<T>,
    onSuccess: (data: T) => void,
    errorMessage: string = 'Ha ocurrido un error inesperado'
  ): void {
    this._loading.set(true);
    this._error.set(null);

    source$.pipe(
      finalize(() => this._loading.set(false))
    ).subscribe({
      next: (data) => onSuccess(data),
      error: (err: HttpErrorResponse) => {
        const msg = err?.message || err?.error?.message ||errorMessage;
        this._error.set(msg);
      }
    })
  }
}
