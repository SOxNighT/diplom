import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SharesComponent } from './shares/shares.component';

const routes: Routes = [
  {
    path: '**', component: SharesComponent,
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
