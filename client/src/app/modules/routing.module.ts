import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PageNotFoundComponent } from '../components/page-not-found/page-not-found.component';
import { ProfileComponent } from '../components/profile/profile.component';
import { HomeComponent } from '../components/home/home.component';
import { AdminComponent } from '../components/admin/admin.component';
import { SubscribeComponent } from '../components/subscribe/subscribe.component';
import { TeachingComponent } from '../components/teaching/teaching.component';
import { DepositComponent } from '../components/deposit/deposit.component';
import { AuthGuard } from '../guards/auth.guard';
import { AdminGuard } from '../guards/admin.guard';


// import { CanDeactivateGuard } from './can-deactivate-guard.service';
// import { AuthGuard } from './auth-guard.service';
// import { SelectivePreloadingStrategy } from './selective-preloading-strategy';

const appRoutes: Routes = [
    {
        path: 'home',
        component: HomeComponent
    },
    {
        path: 'profile',
        component: ProfileComponent,
        canActivate: [AuthGuard]
    },
    {
        path: 'admin',
        loadChildren: '../components/admin/admin.module#AdminModule',
        canLoad: [AdminGuard]
    },
    {
        path: 'subscribe',
        component: SubscribeComponent
    },
    {
        path: 'teaching',
        component: TeachingComponent
    },
    {
        path: 'deposit',
        component: DepositComponent
    },
    //   {
    //     path: 'admin',
    //     loadChildren: 'app/component/admin.module#AdminModule'// ,
    //     // canLoad: [AuthGuard]
    //   },
    //   {
    //     path: 'crisis-center',
    //     loadChildren: 'app/crisis-center/crisis-center.module#CrisisCenterModule',
    //     data: { preload: true }
    //   },
    { path: '', redirectTo: '/home', pathMatch: 'full' },
    { path: '**', component: PageNotFoundComponent }
];

@NgModule({
    imports: [
        RouterModule.forRoot(
            appRoutes,
            {
                // enableTracing: true// , // <-- debugging purposes only
                // preloadingStrategy: SelectivePreloadingStrategy,

            }
        )
    ],
    exports: [
        RouterModule
    ],
    providers: [
        // CanDeactivateGuard,
        // SelectivePreloadingStrategy
    ]
})
export class AppRoutingModule { }
