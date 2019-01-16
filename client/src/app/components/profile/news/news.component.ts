import { Component, OnInit, EventEmitter } from '@angular/core';
import { trigger, state, style, transition, animate } from '@angular/animations';
import { DataApiMockService } from '../../../services/api/data-api-mock.service';
import { News } from '../../../models/news';

@Component({
    // tslint:disable-next-line:component-selector
    selector: 'news-profile',
    templateUrl: './news.component.html',
    styleUrls: ['./news.component.scss'],
    animations: [
        trigger('filterExpand', [
            state('void', style({ width: '0px', minWidth: '0', visibility: 'hidden' })),
            state('*', style({ width: '*', visibility: 'visible' })),
            transition('void <=> *', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
          ]),
      ]
})
export class NewsProfileComponent implements OnInit {
    public focusTrigger = new EventEmitter<boolean>();
    isFilterExpanded = false;
    filter: any;

    public news: News[];
    constructor(public api: DataApiMockService) {
        this.api.getNews().then(value => {
            this.news = value;
        });
    }

    ngOnInit(): void { }

    applyFilter(filterValue: string) {

    }
    focusFilter() {
        this.focusTrigger.emit(true);
    }

    identify(index, item){
        return item.id; 
     }
     
}
