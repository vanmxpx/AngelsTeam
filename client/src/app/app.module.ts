import { FormsModule, ReactiveFormsModule} from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';
import { ProfileComponent } from './components/profile/profile.component';
import { AdminComponent } from './components/admin/admin.component';
import { SignalsComponent } from './components/profile/signals/signals.component';
import { SubsComponent } from './components/admin/subs/subs.component';

import { AppRoutingModule } from './modules/routing.module';
import { CurrentUserService } from './services/current-user.service';
import { LoginDialog } from './components/login/login-dialog.component';
import { FocusDirective } from './directives/focus.directive';

import { PerfectScrollbarModule } from 'ngx-perfect-scrollbar';

import { SubscribeComponent } from './components/subscribe/subscribe.component';
import { SignsComponent } from './components/admin/signs/signs.component';
import { SetsComponent } from './components/admin/sets/sets.component';
import { CdkDetailRowDirective } from './directives/cdk-detail-row.directive';
import { NewSignalDialog } from './components/admin/signs/new-signal/new-signal.component';
import { NewAnnounceDialog } from './components/admin/news/new-announce/new-announce.component';
import { NewsComponent } from './components/admin/news/news.component';
import { NewsProfileComponent } from './components/profile/news/news.component';
import { ApplicationService } from './services/application.service';
import { TeachingComponent } from './components/teaching/teaching.component';
import { DepositComponent } from './components/deposit/deposit.component';
import { environment } from '../environments/environment';
import { DataApiService } from './services/api/data-api.service';
import { DataApiMockService } from './services/api/data-api-mock.service';
import { HttpClientModule } from '@angular/common/http';
import { MaterialModule } from './modules/material.module';
import { NewsControlComponent } from './components/profile/news/news-control/news-control.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ProfileComponent,
    AdminComponent,
    SubsComponent,
    SignsComponent,
    SetsComponent,
    NewsComponent,
    SubscribeComponent,
    PageNotFoundComponent,
    TeachingComponent,
    DepositComponent,
    SignalsComponent,
    NewsProfileComponent,
    // dialogs
    LoginDialog,
    NewSignalDialog,
    NewAnnounceDialog,
    // directives
    CdkDetailRowDirective,
    FocusDirective,
    // controls
    NewsControlComponent
  ],
  imports: [
    HttpClientModule,
    MaterialModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule
  ],
  entryComponents: [ LoginDialog, NewSignalDialog ],
  providers: [
      {
          provide: 'BASE_URL', useFactory: () => {
              if (environment.production) {
                return window.location.protocol + '//' + window.location.host + '/' + (window.location.pathname.split('/')[1] + '/' || '');
              } else {
                return 'http://localhost:5000/';
              }
          }
      },
      ApplicationService,
      DataApiService,
      DataApiMockService,
      CurrentUserService ],
  bootstrap: [ AppComponent ]
})
export class AppModule { }
