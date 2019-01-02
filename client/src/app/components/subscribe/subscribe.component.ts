import { Component, OnInit, Input, ViewChild } from '@angular/core';
import { FormGroup, FormBuilder, Validators, AbstractControl, ValidationErrors, FormControl } from '@angular/forms';
import { MatStepper } from '@angular/material';
import { ValidatorFn } from '@angular/forms';
import { CurrentUserService } from '../../services/current-user.service';

@Component({
    selector: 'subscribe',
    templateUrl: './subscribe.component.html',
    styleUrls: ['./subscribe.component.scss']
})
export class SubscribeComponent implements OnInit {

    logged: boolean = false;
    
    @ViewChild('stepper') stepper: MatStepper;
    selectedSub:  string = 'free';
    paymentStep;
    firstFormGroup: FormGroup;
    registrationFormGroup: FormGroup;
    thirdFormGroup: FormGroup;
    fourthFormGroup: FormGroup;
    constructor(private _formBuilder: FormBuilder,private userService: CurrentUserService) { 
        this.userService.getAutorized()
        .subscribe((value) => {
          this.logged = value;
        });
    }

    ngOnInit(): void {
        this.registrationFormGroup = new FormGroup({
            'firstNameControl': new FormControl(''),
            'lastNameControl': new FormControl(''),
            'loginControl': new FormControl('',[Validators.required]),
            'telegramControl': new FormControl('',[Validators.required]),
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

    getTelegramErrorMessage() {
        return this.registrationFormGroup.controls['telegramControl'].hasError('required') ? 'Введите Telegram аккаунт' :
                '';
    }
    getLoginErrorMessage() {
        return this.registrationFormGroup.controls['loginControl'].hasError('required') ? 'Введите логин' :
                '';
    }
    getPasswordErrorMessage() {
        this.registrationFormGroup.controls['confirmPasswordControl'].setValue('');
        
        return this.registrationFormGroup.controls['passwordControl'].hasError('required') ? 'Введиет пароль' :
                '';
    }
    getConfirmPassErrorMessage() {
        var control = this.registrationFormGroup.controls['confirmPasswordControl'];
        return control.hasError('required') ? 'Подтвердите пароль' :
            control.hasError('mismatch') ? 'Пароли не совпадают' :
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
