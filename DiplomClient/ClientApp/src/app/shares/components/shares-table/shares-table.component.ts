import { Component, OnInit } from '@angular/core';
import { ColumnBase, DataStateChangeEvent, GridDataResult } from "@progress/kendo-angular-grid";
import { CompositeFilterDescriptor, process, State, toDataSourceRequestString } from '@progress/kendo-data-query';
import {TelerikGridColumnViewModel} from "../../models/telerik.grid.column.view.model";
import { Actions, ofType } from '@ngrx/effects';
import {Store} from "@ngrx/store";
import {AppState} from "../../store/app.store";
import { SharesDataSourceService } from '../../services';



@Component({
  selector: 'app-shares-table',
  templateUrl: './shares-table.component.html',
  providers: [
  ]
})
export class SharesTableComponent implements OnInit {

  
  constructor(
    private _store: Store<AppState>,
    private _dataSourceService: SharesDataSourceService,
    private _actions: Actions,
  ) {}

  

  public ngOnInit(): void {
  };

  

}
