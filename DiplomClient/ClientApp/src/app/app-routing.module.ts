import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SharesComponent } from './shares/shares.component';
import { ShareComponent } from './share/share.component';
import { PortfoliosComponent } from './portfolios/portfolios.component';
import { PortfolioComponent } from './portfolio/portfolio.component';

const routes: Routes = [
  {
    path: 'home/shares', component: SharesComponent
  },
  {
    path: 'home/share', component: ShareComponent
  },
  {
    path: 'home/portfolios', component: PortfoliosComponent
  },
  {
    path: 'home/portfolio', component: PortfolioComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
