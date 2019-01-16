import { Component, OnInit, Input } from '@angular/core';
import { News } from '../../../../models/news';

@Component({
    // tslint:disable-next-line:component-selector
    selector: 'news-control',
    templateUrl: './news-control.component.html',
    styleUrls: ['./news-control.component.scss']
})
export class NewsControlComponent implements OnInit {

    @Input() news: News;

    constructor() { }

    ngOnInit(): void { }
}
