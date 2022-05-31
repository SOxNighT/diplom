import { ActionReducerMap } from "@ngrx/store";
import { AppState } from "./app.store";
import { sharesTableReducer } from "./shares-table/reducers/shares-table.reducer"

export const appReducer: ActionReducerMap<AppState, any> = {
  sharesTable: sharesTableReducer
};
