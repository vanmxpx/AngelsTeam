import { FormsModule, ReactiveFormsModule} from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';
import { ProfileComponent } from './components/profile/profile.component';

import { SignalsComponent } from './components/profile/signals/signals.component';
import { SubscriptionsComponent } from './components/profile/subscriptions/subscriptions.component';
import { AppRoutingModule } from './app-routing.module';


import { CurrentUserService } from './services/current-user.service';
import { LoginDialog } from './components/login/login-dialog.component';

import { Parallax, ParallaxConfig, ParallaxModule } from 'ngx-parallax';
import { PerfectScrollbarModule } from 'ngx-perfect-scrollbar';

// Material Components
import {
  MatToolbarModule,
  MatSidenavModule,
  MatMenuModule,
  MatTabsModule,
  MatTooltipModule,
  MatIconModule,
  MatButtonModule,
  MatCheckboxModule,
  MatFormFieldModule,
  MatInputModule,
  MatCardModule,
  MatSnackBarModule,
  MatDialogModule,
  MatTableModule,
  MatGridListModule,
  MatListModule,
  MatSelectModule,
  MatPaginatorModule,
  MatSortModule,
  MatDatepickerModule,
  MatNativeDateModule,
  MatRippleModule } from '@angular/material';
import { FocusDirective } from './directives/focus.directive';


@NgModule({
  exports: [
    MatToolbarModule,
    MatSidenavModule,
    MatMenuModule,
    MatTabsModule,
    MatCheckboxModule,
    MatTooltipModule,
    MatIconModule,
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    MatCardModule,
    MatSnackBarModule,
    MatDialogModule,
    MatTableModule,
    MatGridListModule,
    MatListModule,
    MatSelectModule,
    MatPaginatorModule,
    MatSortModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatRippleModule ]
})
export class MaterialModule {}

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ProfileComponent,
    PageNotFoundComponent,
    SignalsComponent,
    SubscriptionsComponent,
    LoginDialog,
    FocusDirective
  ],
  imports: [
    ParallaxModule,
    MaterialModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule
  ],
  entryComponents: [LoginDialog],
  providers: [CurrentUserService],
  bootstrap: [AppComponent]
})
export class AppModule { }
