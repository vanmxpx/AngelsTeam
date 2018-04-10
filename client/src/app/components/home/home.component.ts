import { Component, OnInit } from '@angular/core';

import { ErrorStateMatcher } from '@angular/material';
import { ParallaxConfig } from 'ngx-parallax';
import { FormControl, Validators, FormGroupDirective, NgForm } from '@angular/forms';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
    parallaxConfig: ParallaxConfig = {
        initialValue: 0,
        ratio: .22
      };

        emailFormControl = new FormControl('', [
          Validators.required,
          Validators.email,
        ]);

        passwordFormControl = new FormControl('', [
          Validators.required,
          Validators.email,
        ]);

        matcher = new MyErrorStateMatcher();
        matcherPassword = new MyErrorStateMatcher();

        ngOnInit(): void {
        }
}

/** Error when invalid control is dirty, touched, or submitted. */
export class MyErrorStateMatcher implements ErrorStateMatcher {
    isErrorState(control: FormControl | null, form: FormGroupDirective | NgForm | null): boolean {
      const isSubmitted = form && form.submitted;
      return !!(control && control.invalid && (control.dirty || control.touched || isSubmitted));
    }
  }
