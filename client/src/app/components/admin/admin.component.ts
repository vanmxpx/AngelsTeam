import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'admin-panel',
    templateUrl: './admin.component.html',
    styleUrls: ['./admin.component.scss']
})
export class AdminComponent implements OnInit {
    state: string = "sub";
    
    constructor() { }

    ngOnInit(): void { }
}
