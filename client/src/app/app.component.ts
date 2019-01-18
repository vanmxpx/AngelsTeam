import { Component, OnDestroy } from '@angular/core';
import { MatDialog } from '@angular/material';
import { LoginDialog } from './components/login/login-dialog.component';
import { ApplicationService } from './services/application.service';
import { AuthenticationService } from './services/api/security/authentication.service';
import { User, UserType } from './models/user';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.scss']
})
export class AppComponent {

    mobileQuery: MediaQueryList;
    profile: User;
    userType = UserType;
    constructor(
        private dialog: MatDialog,
        private auth: AuthenticationService,
        private appService: ApplicationService) {
        this.appService.getMobileQuery()
            .subscribe((value) => {
                this.mobileQuery = value;
            });
        this.auth.getProfile()
            .subscribe((value) => {
                this.profile = value;
            });
    }

    openDialog(): void {
        this.dialog.open(LoginDialog);
    }

}
