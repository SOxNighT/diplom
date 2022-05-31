import { GridDataResult } from "@progress/kendo-angular-grid";
import { SharesGridOutputDto } from "../../../models/shares.grid.output.dto";

export interface SharesTableState {
  gridModel: SharesGridOutputDto | undefined,
  data: GridDataResult | undefined
}

export const initialSharesState: SharesTableState = {
  gridModel: undefined,
  data: undefined
};
