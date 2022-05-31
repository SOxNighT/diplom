import {NgModule} from "@angular/core";
import {RouterModule, Routes} from "@angular/router";
import { SharesComponent } from "./shares.component";

const routes: Routes = [
  {
    component: SharesComponent, path: ''
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SharesRoutingModule { }
