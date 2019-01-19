import { NgModule } from '@angular/core';
import { SubsComponent } from './subs/subs.component';
import { SetsComponent } from './sets/sets.component';
import { NewsComponent } from './news/news.component';
import { SignalManagerComponent } from './signal-manager/signal-manager.component';
import { NewSignalDialog } from './signal-manager/new-signal/new-signal.component';
import { NewAnnounceDialog } from './news/new-announce/new-announce.component';
import { DataApiService } from '../../services/api/data-api.service';
import { AdminComponent } from './admin.component';
import { AdminRoutingModule } from './admin-routing.module';
import { MaterialModule } from '../../modules/material.module';
import { CommonModule } from '@angular/common';
import { CdkDetailRowDirective } from '../../directives/cdk-detail-row.directive';

@NgModule({
    declarations: [
        AdminComponent,
        SubsComponent,
        SetsComponent,
        NewsComponent,
        SignalManagerComponent,
        // directives
        CdkDetailRowDirective,
        // dialogs
        NewSignalDialog,
        NewAnnounceDialog,
    ],
    imports: [
        CommonModule,
        MaterialModule,
        AdminRoutingModule
    ],
    entryComponents: [ NewSignalDialog ],
    providers: [
        DataApiService
    ]
})
export class AdminModule { }
