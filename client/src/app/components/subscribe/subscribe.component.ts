import { Component, OnInit, Input, ViewChild } from '@angular/core';
import { FormGroup, FormBuilder, Validators, AbstractControl, ValidationErrors } from '@angular/forms';
import { MatStepper } from '@angular/material';

@Component({
    selector: 'subscribe',
    templateUrl: './subscribe.component.html',
    styleUrls: ['./subscribe.component.scss']
})
export class SubscribeComponent implements OnInit {

    @ViewChild('stepper') stepper: MatStepper;
    selectedSub:  string = 'free';
    paymentStep;
    firstFormGroup: FormGroup;
    registrationFormGroup: FormGroup;
    thirdFormGroup: FormGroup;
    fourthFormGroup: FormGroup;
    constructor(private _formBuilder: FormBuilder) { }

    ngOnInit(): void {
        this.registrationFormGroup = this._formBuilder.group({
            firstNameControl: [''],
            lastNameControl: [''],
            loginControl: ['', Validators.required],
            emailControl: ['', Validators.required, Validators.email],
            passwordControl: ['', Validators.required],
            confirmPasswordControl: ['', Validators.required, passwordMatchValidator],
            
        });
        this.firstFormGroup = this._formBuilder.group({
            thirdFormGroup: ['', Validators.required]
        });
        this.fourthFormGroup = this._formBuilder.group({
            fourthControl: ['', Validators.required, ]
        });
     }

     getSub(sub: string): void {
        this.selectedSub = sub;
        this.stepper._steps.first.completed = true;

        this.stepper.next();
      }

    getEmailErrorMessage() {
        return this.registrationFormGroup.controls['emailControl'].hasError('required') ? 'You must enter a value' :
                this.registrationFormGroup.controls['emailControl'].hasError('email') ? 'Not a valid email' :
                '';
    }
    getLoginErrorMessage() {
        return this.registrationFormGroup.controls['loginControl'].hasError('required') ? 'You must enter a value' :
                '';
    }
    getPasswordErrorMessage() {
        return this.registrationFormGroup.controls['passwordControl'].hasError('required') ? 'You must enter a value' :
                '';
    }
    getConfirmPassErrorMessage() {
        return this.registrationFormGroup.controls['confirmPasswordControl'].hasError('required') ? 'You must enter a value' :
                this.registrationFormGroup.controls['confirmPasswordControl'].hasError('mismatch') ? 'Passwords mismatch' :
                '';
    }
}
function passwordMatchValidator(g: FormGroup) {
    return g.get('passwordControl').value === g.get('confirmPasswordControl').value
       ? null : {'mismatch': true};
 }
