import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { GridDataResult } from "@progress/kendo-angular-grid";
import { Observable } from "rxjs";
import { State, toDataSourceRequestString } from "@progress/kendo-data-query";

@Injectable()
export class SharesDataSourceService {

  constructor(
    private _http: HttpClient
  ) {}

  public getData(inputDto: State): Observable<GridDataResult> {
    return this._http.get<GridDataResult>(`/agreement/api/v1/agreements-regional-admin-data-source/data?${toDataSourceRequestString(inputDto)}`);
  };
}
