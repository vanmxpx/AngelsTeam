import { Component, OnInit } from '@angular/core';

@Component({
    // tslint:disable-next-line:component-selector
    selector: 'profile',
    templateUrl: './profile.component.html',
    styleUrls: ['./profile.component.scss']
})
export class ProfileComponent implements OnInit {

    state: string = 'news';

    constructor( ) { }

    ngOnInit(): void { }

    onLinkClick(event) {
        switch(event.tab.textLabel) {
            case 'Новости': { 
                this.state = 'news'; 
                break; 
             } 
             case 'Сигналы': { 
                this.state = 'signs'; 
                break; 
             } 
             default: { 
                this.state = 'sets'; 
                break; 
             } 
        }
    }
}
