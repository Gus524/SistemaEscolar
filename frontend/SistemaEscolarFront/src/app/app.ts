import {Component, Inject, PLATFORM_ID, signal} from '@angular/core';
import { RouterOutlet } from '@angular/router';
import {isPlatformBrowser, NgOptimizedImage} from '@angular/common';
import {Loader} from '@app/shared/ui/loader/loader';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Loader],
  templateUrl: './app.html',
  styleUrl: './app.scss'
})
export class App {
  isBrowser = signal(false);

  constructor(@Inject(PLATFORM_ID) private platformId: Object) {
    this.isBrowser.set(isPlatformBrowser(this.platformId));
  }
}
