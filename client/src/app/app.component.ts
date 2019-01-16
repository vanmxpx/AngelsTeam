import { Component, OnDestroy } from '@angular/core';
import { MatDialog } from '@angular/material';
import { LoginDialog } from './components/login/login-dialog.component';
import { CurrentUserService } from './services/current-user.service';
import { ApplicationService } from './services/application.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {

  mobileQuery: MediaQueryList;
  adminMode: boolean = false;
  profileName: string = '';
  logged: boolean = false;
  constructor(public dialog: MatDialog,
    private userService: CurrentUserService, private appService: ApplicationService) {
      this.appService.getMobileQuery()
        .subscribe((value) => {
          this.mobileQuery = value;
      });
      this.userService.getLogin()
      .subscribe((value) => {
        this.adminMode = value === 'admin';
      });
      this.userService.getAutorized()
      .subscribe((value) => {
        this.logged = value;
      });
      this.userService.getLogin()
      .subscribe((value) => {
        this.profileName = value;
      });
    }

  ngAfterViewInit() {

  }
  openDialog(): void {
    const dialogRef = this.dialog.open(LoginDialog, {
      // width: '250px',
      // data: { name: this.name, animal: this.animal }
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
      // this.animal = result;
    });
  }
}
