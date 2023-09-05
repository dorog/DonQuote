import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class SearchQuoteClientService {
  public quotes: PagedItems<Quote>;
  readonly baseUrl: string;

  constructor(public http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
    this.quotes = { currentPageNumber: 0, totalPages: 0, items: [] };
  }

  getQuotes(quoteFilter: QuoteFilter): Observable<PagedItems<Quote>> {
    return of({
      currentPageNumber: 0,
      totalPages: 10,
      items: [
        { originatorName: 'name', message: 'message' },
        { originatorName: 'name2', message: 'message2' },
        { originatorName: 'name2', message: 'message2' },
        { originatorName: 'name2', message: 'message2' },
        { originatorName: 'name2', message: 'message2' },
        { originatorName: 'name2', message: 'message2' },
        { originatorName: 'name2', message: 'message2' },
        { originatorName: 'name2', message: 'message2' },
      ],
    } as PagedItems<Quote>);

    /*return this.http.post<PagedItems<Quote>>(
      this.baseUrl + 'searchquote/search',
      quoteFilter
    );*/
  }
}

export interface QuoteFilter {
  pageNumber: number;
  message: string;
  originatorName: string;
}

export interface Quote {
  message: string;
  originatorName: string;
  cite: string;
}

export interface PagedItems<T> {
  currentPageNumber: number;
  totalPages: number;
  items: T[];
}
