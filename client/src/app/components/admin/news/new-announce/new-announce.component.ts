import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { Router } from '@angular/router';

@Component({
    // tslint:disable-next-line:component-selector
    selector: 'new-announce',
    templateUrl: 'new-announce.component.html',
    styleUrls: ['new-announce.component.scss']
  })
  // tslint:disable-next-line:component-class-suffix
  export class NewAnnounceDialog {
    static dialogRes = true;

    constructor(
      public dialogRef: MatDialogRef<NewAnnounceDialog>,
      private router: Router,
      @Inject(MAT_DIALOG_DATA) public data: any) { }


      onSave(): void {

      }
      addPhoto(){

      }
      removePhoto(){
        
      }
      onNoClick(): void {
        this.dialogRef.close();
      }
}
