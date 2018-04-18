import { Component } from '@angular/core';
import { MatDialog } from '@angular/material';
import { LoginDialog } from './components/login/login-dialog.component';
import { CurrentUserService } from './services/current-user.service';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  adminMode: boolean = false;
  constructor(public dialog: MatDialog, public userService: CurrentUserService) {}

  ngAfterViewInit() {
    //Called after ngAfterContentInit when the component's view has been initialized. Applies to components only.
    //Add 'implements AfterViewInit' to the class.
    this.userService.getName().subscribe((value) => {
      this.adminMode = value === 'admin';
    });
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
