import { Routes, RouterModule } from '@angular/router';
import { PageNotFoundComponent } from '../page-not-found/page-not-found.component';
import { NgModule } from '@angular/core';
import { AdminComponent } from './admin.component';

const routes: Routes = [
    { path: '', component: AdminComponent },
];

@NgModule({
    imports: [
        RouterModule.forChild(routes)
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
