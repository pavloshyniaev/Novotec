import { enableProdMode } from '@angular/core';
import { bootstrapApplication } from '@angular/platform-browser';
import { AppComponent } from './app/app.component';
import { provideAnimations } from '@angular/platform-browser/animations';
import { environment } from './environments/environment'; 
import { HttpClientModule, provideHttpClient } from '@angular/common/http'; // ✅ Import provideHttpClient

if (environment.production) {
  enableProdMode();
}

bootstrapApplication(AppComponent, {
  providers: [provideHttpClient(), provideAnimations()] // ✅ Add provideHttpClient() to providers
}).catch(err => console.error(err));
