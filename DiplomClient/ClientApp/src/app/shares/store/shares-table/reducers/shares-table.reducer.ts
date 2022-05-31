import {Action, createReducer, on} from '@ngrx/store';
import { initialSharesState, SharesTableState } from '../states';

const sharesTableReducerCreator = createReducer(
  initialSharesState
);

export function sharesTableReducer(state: SharesTableState | undefined, action: Action) {
  return sharesTableReducerCreator(state, action);
}
