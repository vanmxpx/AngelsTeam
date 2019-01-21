import { Component, OnInit, OnDestroy } from '@angular/core';
import { AuthenticationService } from '../../services/api/security/authentication.service';
import { Subscription } from 'rxjs';
import { User } from '../../models/user';

@Component({
    // tslint:disable-next-line:component-selector
    selector: 'profile',
    templateUrl: './profile.component.html',
    styleUrls: ['./profile.component.scss']
})
export class ProfileComponent implements OnInit, OnDestroy {
    private subscriptions: Subscription[] = [];
    state: string = 'news';
    profile: User;

    constructor(private auth: AuthenticationService) {
        this.subscriptions.push(
            this.auth.getProfile().subscribe(value => this.profile = value)
        );
    }

    ngOnInit(): void { }
    ngOnDestroy(): void {
        this.subscriptions.forEach(value => value.unsubscribe());
    }

    onLinkClick(event) {
        switch (event.tab.textLabel) {
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
