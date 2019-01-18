import { FormsModule, ReactiveFormsModule} from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';
import { ProfileComponent } from './components/profile/profile.component';
import { SignalsComponent } from './components/profile/signals/signals.component';

import { AppRoutingModule } from './modules/routing.module';
import { CurrentUserService } from './services/current-user.service';
import { LoginDialog } from './components/login/login-dialog.component';
import { FocusDirective } from './directives/focus.directive';

import { PerfectScrollbarModule } from 'ngx-perfect-scrollbar';

import { SubscribeComponent } from './components/subscribe/subscribe.component';
import { SetsComponent } from './components/admin/sets/sets.component';
import { CdkDetailRowDirective } from './directives/cdk-detail-row.directive';
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
import { SignalManagerComponent } from './components/admin/signal-manager/signal-manager.component';
import { NewSignalDialog } from './components/admin/signal-manager/new-signal/new-signal.component';
import { SignalControlComponent } from './components/profile/signals/signal-control/signal-control.component';
import { AuthenticationService } from './services/api/security/authentication.service';
import { AuthGuard } from './guards/auth.guard';
import { JwtHelperService, JwtModule } from '@auth0/angular-jwt';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ProfileComponent,
    SubscribeComponent,
    PageNotFoundComponent,
    TeachingComponent,
    DepositComponent,
    SignalsComponent,
    NewsProfileComponent,
    // dialogs
    LoginDialog,
    // directives
    CdkDetailRowDirective,
    FocusDirective,
    // controls
    SignalControlComponent,
    NewsControlComponent
  ],
  imports: [
    HttpClientModule,
    MaterialModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    JwtModule.forRoot({
        config: {
            tokenGetter: () => {
                return localStorage.getItem('token');
            }
        }
    })
  ],
  entryComponents: [ LoginDialog ],
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
      AuthGuard,
      JwtHelperService,
      ApplicationService,
      AuthenticationService,
      DataApiService,
      DataApiMockService,
      CurrentUserService ],
  bootstrap: [ AppComponent ]
})
export class AppModule { }
