import { LOCALE_ID, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { EffectsModule } from '@ngrx/effects';
import { StoreRouterConnectingModule } from '@ngrx/router-store';
import { StoreModule } from '@ngrx/store';
import { StoreDevtoolsModule } from '@ngrx/store-devtools';
import { ToastrModule } from 'ngx-toastr';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NgxMaskModule } from 'ngx-mask';
import {APP_BASE_HREF, registerLocaleData} from '@angular/common';
import '@progress/kendo-angular-intl/locales/ru/all';
import '@progress/kendo-angular-intl/locales/ru/calendar';

registerLocaleData(localeRu, 'ru');

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    ToastrModule.forRoot(),
    NgxMaskModule.forRoot(),
    StoreDevtoolsModule.instrument({
      maxAge: 25,
      features: {
        pause: false,
        lock: true,
        persist: true
      }
    }),
    StoreRouterConnectingModule.forRoot()
  ],
  providers: [
    {
      provide: LOCALE_ID,
      useValue: 'ru'},
    {
      provide: APP_BASE_HREF,
      useValue: '/home'
    },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
function localeRu(localeRu: any, arg1: string) {
  throw new Error('Function not implemented.');
}

