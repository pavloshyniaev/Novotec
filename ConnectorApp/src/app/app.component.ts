import { Component } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { SynchronizerComponent } from './synchronizer/synchronizer.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [HttpClientModule, SynchronizerComponent],
  template: `<app-synchronizer></app-synchronizer>`,
  styleUrls: ['./app.component.css']
})
export class AppComponent {}
