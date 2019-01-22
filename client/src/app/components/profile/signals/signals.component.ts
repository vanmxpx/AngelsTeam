import { Component, OnInit, EventEmitter } from '@angular/core';
import { trigger, state, style, transition, animate } from '@angular/animations';
import { Signal } from '../../../models/Signal';
import { DataApiService } from '../../../services/api/data-api.service';

@Component({
    // tslint:disable-next-line:component-selector
    selector: 'signals',
    templateUrl: './signals.component.html',
    styleUrls: ['./signals.component.scss'],
    animations: [
        trigger('detailExpand', [
          state('void', style({ height: '0px', minHeight: '0', visibility: 'hidden' })),
          state('*', style({ height: '*', visibility: 'visible' })),
          transition('void <=> *', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
        ]),
        trigger('filterExpand', [
            state('void', style({ width: '0px', minWidth: '0', visibility: 'hidden' })),
            state('*', style({ width: '*', visibility: 'visible' })),
            transition('void <=> *', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
          ]),
      ]
})
export class SignalsComponent implements OnInit {
    public focusTrigger = new EventEmitter<boolean>();
    isFilterExpanded = false;
    filter: any;
    signals: Signal[];
    constructor(private api: DataApiService) {
        this.api.getSignals().then(value => {
            this.signals = value;
        });
     }

    ngOnInit(): void { }

    applyFilter(filterValue: string) {

    }
    focusFilter() {
        this.focusTrigger.emit(true);
    }

    identify(index, item) {
        return item.id;
    }
}
