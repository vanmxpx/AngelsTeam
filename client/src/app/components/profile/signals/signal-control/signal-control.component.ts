import { Component, OnInit, EventEmitter, Input } from '@angular/core';
import { trigger, state, style, transition, animate } from '@angular/animations';
import { Signal } from '../../../../models/Signal';
import { SignalLevel } from '../../../../models/signal-status';

@Component({
    // tslint:disable-next-line:component-selector
    selector: 'signal-control',
    templateUrl: './signal-control.component.html',
    styleUrls: ['./signal-control.component.scss']
})
export class SignalControlComponent implements OnInit {
    @Input() signal: Signal;
    constructor() { }

    ngOnInit(): void { }

    icon(): string {
        switch (this.signal.status) {
            case SignalLevel.Hight:
                return 'priority_high';
            case SignalLevel.Middle:
                return 'warning';
            case SignalLevel.Low:
                return 'beenhere';
            case SignalLevel.Info:
                return 'info';
            default:
                return '';
        }
    }
    iconTooltip(): string {
        switch (this.signal.status) {
            case SignalLevel.Hight:
                return 'Риск: Высокий. Торговля опасна';
            case SignalLevel.Middle:
                return 'Риск: Средний';
            case SignalLevel.Low:
                return 'Риск: Низкий';
            case SignalLevel.Info:
                return 'Для Вашей информации';
            default:
                return '';
        }
    }
}
