import { enableProdMode } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { registerLocaleData } from '@angular/common';
import { AppModule } from './app/app.module';
import localeRu from '@angular/common/locales/ru';
import localeRuExtra from '@angular/common/locales/extra/ru';

enableProdMode();
registerLocaleData(localeRu, 'ru-RU', localeRuExtra);
platformBrowserDynamic().bootstrapModule(AppModule)
  .catch(err => console.error(err));
