import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA, ErrorStateMatcher } from '@angular/material';
import { CurrentUserService } from '../../services/current-user.service';
import { Validators, FormControl, FormGroupDirective, NgForm, AbstractControl, ValidationErrors } from '@angular/forms';
import { MyErrorStateMatcher } from '../home/home.component';
import { Router } from '@angular/router';

@Component({
    // tslint:disable-next-line:component-selector
    selector: 'login-dialog',
    templateUrl: 'login-dialog.component.html',
    styleUrls: ['login-dialog.component.scss']
  })
  // tslint:disable-next-line:component-class-suffix
  export class LoginDialog {
    static dialogRes = true;

     _currLogin: string;
     _currPass: string;

    show = false;
    loginFormControl = new FormControl('', [
      Validators.required
    ]);

    passwordFormControl = new FormControl('', [
      Validators.required,
      this.validPass
    ]);

    matchLogin = new MyErrorStateMatcher();
    matchPassword = new MyErrorStateMatcher();

    constructor(
      public dialogRef: MatDialogRef<LoginDialog>,
      private userService: CurrentUserService,
      private router: Router,
      @Inject(MAT_DIALOG_DATA) public data: any) { }

    authPress(key: string): void {
      if (key === 'Enter') {
        this.onLogIn();
      }
    }

    onLogIn(): void {
      if (this.userService.autorize(this._currLogin, this._currPass)) {
        this.dialogRef.close(true);
       this.router.navigate(['/profile']);
      } else {
        LoginDialog.dialogRes = false;
      }
      this.passwordFormControl.updateValueAndValidity();
    }
    onNoClick(): void {
      this.dialogRef.close();
    }
 validPass(control: AbstractControl): ValidationErrors {
    return LoginDialog.dialogRes  ? null : { valid: true };
  }
}
