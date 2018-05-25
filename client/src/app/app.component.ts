import { Component, OnDestroy } from '@angular/core';
import { MatDialog } from '@angular/material';
import { LoginDialog } from './components/login/login-dialog.component';
import { CurrentUserService } from './services/current-user.service';
import { ApplicationService } from './services/application.service';
import { Observable, Subject } from 'rxjs-compat';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnDestroy {
  // Reactive
  private ngUnsubscribe: Subject<void> = new Subject<void>();

  mobileQuery: MediaQueryList;
  adminMode: boolean = false;
  constructor(public dialog: MatDialog, 
    private userService: CurrentUserService, private appService: ApplicationService) {
      this.appService.getMobileQuery()
        .takeUntil(this.ngUnsubscribe)
        .subscribe((value) => {
          this.mobileQuery = value;
      });
      this.userService.getName().subscribe((value) => {
        this.adminMode = value === 'admin';
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

  ngOnDestroy() {
    this.ngUnsubscribe.next();
    this.ngUnsubscribe.complete();
  }
}
