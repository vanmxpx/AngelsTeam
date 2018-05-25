import { Component, OnInit, Input, ViewChild } from '@angular/core';
import { FormGroup, FormBuilder, Validators, AbstractControl, ValidationErrors, FormControl } from '@angular/forms';
import { MatStepper } from '@angular/material';
import { ValidatorFn } from '@angular/forms';

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
        this.registrationFormGroup = new FormGroup({
            'firstNameControl': new FormControl(''),
            'lastNameControl': new FormControl(''),
            'loginControl': new FormControl('',[Validators.required]),
            'emailControl': new FormControl('',[Validators.required, Validators.email]),
            'passwordControl': new FormControl('',[Validators.required]),
            'confirmPasswordControl': new FormControl('',[Validators.required, passwordMatchValidator()]),
            
        });
        this.firstFormGroup = this._formBuilder.group({
            thirdFormGroup: ['', Validators.required]
        });
        this.fourthFormGroup = this._formBuilder.group({
            fourthControl: ['', Validators.required]
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
function passwordMatchValidator(): ValidatorFn {
    return (control: AbstractControl): {[key: string]: any} => {
        if(control.parent === undefined)
            return null;
        return control.parent.get('passwordControl').value === control.parent.get('confirmPasswordControl').value
        ? null : { 'mismatch': true };
    };

 }
