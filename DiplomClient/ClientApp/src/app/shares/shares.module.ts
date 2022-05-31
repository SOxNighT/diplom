import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {BodyModule, GridModule, RowFilterModule, SharedModule} from "@progress/kendo-angular-grid";
import {StoreModule} from "@ngrx/store";
import { appReducer } from "./store/app.reducer";
import { EffectsModule } from '@ngrx/effects';
import { SharesComponent } from './shares.component';
import { SharesHeaderComponent } from './components/shares-header/shares-header.component';
import { SharesTableComponent } from './components/shares-table/shares-table.component';


@NgModule({
  declarations: [
    SharesComponent,
    SharesHeaderComponent,
    SharesTableComponent
  ],
  imports: [
    CommonModule,
    GridModule,
    RowFilterModule,
    EffectsModule.forFeature([
    ]),
    BodyModule
  ],
  providers: [
  ]
})
export class SharesModule { }
