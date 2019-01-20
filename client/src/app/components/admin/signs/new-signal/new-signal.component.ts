import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { Router } from '@angular/router';

@Component({
    // tslint:disable-next-line:component-selector
    selector: 'new-signal',
    templateUrl: 'new-signal.component.html',
    styleUrls: ['new-signal.component.scss']
  })
  // tslint:disable-next-line:component-class-suffix
  export class NewSignalDialog {
    static dialogRes = true;

    constructor(
      public dialogRef: MatDialogRef<NewSignalDialog>,
      private router: Router,
      @Inject(MAT_DIALOG_DATA) public data: any) { }


      onSave(): void {

      }
      addPhoto(){

      }
      removePhoto(){
        
      }
      addTP() {
        
      }
      onNoClick(): void {
        this.dialogRef.close();
      }
}
