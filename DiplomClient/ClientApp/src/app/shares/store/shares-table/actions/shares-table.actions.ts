import {GridDataResult} from "@progress/kendo-angular-grid";
import {createAction, props} from "@ngrx/store";
import { State } from '@progress/kendo-data-query';

export enum AgreementsRegionalTableActions {
  LoadAgreementsRegionalGrid = '[LoadAgreementsRegionalTable] Load Agreements Regional Grid',
}

export const loadAgreementsRegionalGrid = createAction(
  AgreementsRegionalTableActions.LoadAgreementsRegionalGrid
);