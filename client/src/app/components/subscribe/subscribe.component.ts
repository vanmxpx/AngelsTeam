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
    secondFormGroup: FormGroup;
    thirdFormGroup: FormGroup;
    fourthFormGroup: FormGroup;
    constructor(private _formBuilder: FormBuilder) { }

    ngOnInit(): void {
        this.secondFormGroup = this._formBuilder.group({
            secondControl: ['', Validators.required]
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
}
