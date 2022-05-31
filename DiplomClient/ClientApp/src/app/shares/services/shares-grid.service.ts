import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { SharesGridOutputDto } from "../models/shares.grid.output.dto";

@Injectable()
export class SharesGridService {

  constructor(
    private _http: HttpClient
  ) {}

  public getGridModel(): Observable<SharesGridOutputDto> {
    return this._http.get<SharesGridOutputDto>('/agreement/api/v1/agreements-regional-admin-grid/grid');
  };
}
