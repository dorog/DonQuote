import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import {
  PagedItems,
  Quote,
  SearchQuoteClientService,
} from 'src/app/services/search-quote-client.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['home.component.scss'],
})
export class HomeComponent {
  public formGroup: FormGroup;
  public quotes?: PagedItems<Quote>;

  public isFall = false;

  constructor(public searchQuoteClient: SearchQuoteClientService) {
    this.formGroup = new FormGroup({
      searchText: new FormControl(),
    });
  }

  onSearch(): void {
    this.isFall = true;
    this.searchQuoteClient
      .getQuotes({
        message: '', //this.formGroup.controls['searchText'].value,
        originatorName: this.formGroup.controls['searchText'].value,
        pageNumber: 1,
      })
      .subscribe((quotes) => (this.quotes = quotes));
  }
}
