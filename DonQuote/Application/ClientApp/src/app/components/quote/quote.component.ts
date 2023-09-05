import { Component, Input } from '@angular/core';
import { Quote } from 'src/app/services/search-quote-client.service';

@Component({
  selector: 'app-quote',
  templateUrl: './quote.component.html',
  styleUrls: ['./quote.component.scss'],
})
export class QuoteComponent {
  @Input()
  public quote: Quote;

  constructor() {
    this.quote = { message: '', originatorName: '', cite: '' };
  }
}
