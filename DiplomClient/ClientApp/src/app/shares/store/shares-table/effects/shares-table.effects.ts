import { Injectable } from "@angular/core";
import { Actions, createEffect, ofType } from "@ngrx/effects";
import { Store } from "@ngrx/store";
import { GridDataResult } from "@progress/kendo-angular-grid";
import { EMPTY } from "rxjs";
import { catchError, switchMap, map } from 'rxjs/operators';
import { SharesDataSourceService, SharesGridService } from "../../../services";
import { AppState } from "../../app.store";


@Injectable()
export class AgreementsRegionalTableEffects {
  constructor(
    private _gridService: SharesGridService,
    private _dataSourceService: SharesDataSourceService,
    private _actions: Actions,
    private _store: Store<AppState>
  ) {}

  
  
}
