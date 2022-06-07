import { Component, OnInit, ViewChild } from '@angular/core';
import { DataBindingDirective } from '@progress/kendo-angular-grid';
import { process } from '@progress/kendo-data-query';
import { shares } from './shares';

@Component({
  selector: 'my-shares',
  templateUrl: './shares.component.html',
})
export class SharesComponent implements OnInit {
  @ViewChild(DataBindingDirective) dataBinding: DataBindingDirective;
  public gridData: unknown[] = shares;
  public gridView: unknown[];

  public mySelection: string[] = [];

  public ngOnInit(): void {
    this.gridView = this.gridData;
  }

  public onFilter(input: Event): void {
    const inputValue = (input.target as HTMLInputElement).value;

    this.gridView = process(this.gridData, {
      filter: {
        logic: 'or',
        filters: [
          {
            field: 'name',
            operator: 'contains',
            value: inputValue,
          },
          {
            field: 'tiker',
            operator: 'contains',
            value: inputValue,
          }
        ],
      },
    }).data;

    this.dataBinding.skip = 0;
  }

  public shareUrl(dataItem: { id: string;}): string {
    return "/home/share?id=" + dataItem.id;
  }
}
