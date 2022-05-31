import { Component, OnDestroy, OnInit } from '@angular/core';
import { SimpleModalService } from 'ngx-simple-modal';
import { ActiveToast, ToastrService } from 'ngx-toastr';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent implements OnInit, OnDestroy {



  constructor(private simpleModalService: SimpleModalService,
              private toasterService: ToastrService
  ) {
  }

  ngOnInit() {  }

  ngOnDestroy() {
  }



}

