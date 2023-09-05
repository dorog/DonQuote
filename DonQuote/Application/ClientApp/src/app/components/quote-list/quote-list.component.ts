import { Component, Input } from '@angular/core';
import {
  PagedItems,
  Quote,
} from 'src/app/services/search-quote-client.service';

@Component({
  selector: 'app-quote-list',
  templateUrl: './quote-list.component.html',
  styleUrls: ['./quote-list.component.scss'],
})
export class QuoteListComponent {
  @Input()
  public quotes?: PagedItems<Quote>;

  constructor() {}
}
