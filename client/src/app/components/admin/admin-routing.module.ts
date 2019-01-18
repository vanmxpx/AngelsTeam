import { Routes, RouterModule } from '@angular/router';
import { PageNotFoundComponent } from '../page-not-found/page-not-found.component';
import { NgModule } from '@angular/core';
import { AdminComponent } from './admin.component';

const appRoutes: Routes = [
    { path: '', component: AdminComponent },
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
export class AdminRoutingModule { }
