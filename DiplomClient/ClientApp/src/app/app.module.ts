import { NgModule }      from '@angular/core'; 
import { FormsModule }   from '@angular/forms';
import { AppComponent }   from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { SharesComponent } from './shares/shares.component';
import { ExcelModule, GridModule, PDFModule } from '@progress/kendo-angular-grid';
import { InputsModule } from '@progress/kendo-angular-inputs';
import { CommonModule } from '@angular/common';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ChartsModule } from '@progress/kendo-angular-charts';
import 'hammerjs';
import { ShareComponent } from './share/share.component';
import { PortfoliosComponent } from './portfolios/portfolios.component';
import { PortfolioComponent } from './portfolio/portfolio.component';
@NgModule({
    imports:      [ 
        FormsModule, 
        AppRoutingModule, 
        HttpClientModule,
        BrowserAnimationsModule,
        CommonModule,
        GridModule,
        ChartsModule,
        InputsModule,
        PDFModule,
        ExcelModule
    ],
    declarations: [ AppComponent, ShareComponent, SharesComponent, PortfoliosComponent, PortfolioComponent],
    bootstrap:    [ AppComponent, ShareComponent, SharesComponent, PortfoliosComponent, PortfolioComponent]
})
export class AppModule { }