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

@NgModule({
    declarations: [
        AdminComponent,
        SubsComponent,
        SetsComponent,
        NewsComponent,
        SignalManagerComponent,
        // dialogs
        NewSignalDialog,
        NewAnnounceDialog,
    ],
    imports: [
        AdminRoutingModule
    ],
    entryComponents: [ NewSignalDialog ],
    providers: [
        DataApiService
    ]
})
export class AdminModule { }
