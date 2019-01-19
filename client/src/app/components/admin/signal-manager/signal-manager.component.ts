import { Component, ViewChild, AfterViewInit, ChangeDetectorRef } from '@angular/core';

import { MatPaginator, MatSort, MatTableDataSource, MatSnackBar, MatDialog } from '@angular/material';
import { trigger, state, style, transition, animate } from '@angular/animations';
import { NewSignalDialog } from './new-signal/new-signal.component';
import { Signal } from '../../../models/Signal';
import { SignalLevel, Period } from '../../../models/signal-status';
@Component({
    selector: 'signal-manager',
    templateUrl: './signal-manager.component.html',
    styleUrls: ['./signal-manager.component.scss'],
    animations: [
      trigger('detailExpand', [
        state('void', style({ height: '0px', minHeight: '0', visibility: 'hidden' })),
        state('*', style({ height: '*', visibility: 'visible' })),
        transition('void <=> *', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
      ]),
      trigger('filterExpand', [
          state('void', style({ width: '0px', minWidth: '0', visibility: 'hidden' })),
          state('*', style({ width: '*', visibility: 'visible' })),
          transition('void <=> *', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
        ]),
    ],
})
export class SignalManagerComponent implements AfterViewInit {

    // Details
    expandedElement: any;

    users: Signal[] = [];
    SignalLevel = SignalLevel;

    date: Date = new Date();
    displayedColumns = ['Id', 'Coin', 'Date', 'Status', 'Edit', 'Remove'];
    dataSourceSigns: MatTableDataSource<Signal>;

    @ViewChild('paginatorSigns') paginatorSigns: MatPaginator;
    @ViewChild(MatSort) sort: MatSort;

    constructor(public snackBar: MatSnackBar, public dialog: MatDialog) {
      setInterval(() => {
         this.date = new Date();  }, 1000);
      // Create 100 users

      for (let i = 1; i <= 78; i++) { this.users.push(createNewUser(i)); }

      // Assign the data to the data source for the table to render
      this.dataSourceSigns = new MatTableDataSource(this.users);
    }

    ngOnInit() {
      this.dataSourceSigns.sort = this.sort;
    }
    /**
     * Set the paginator and sort after the view init since this component will
     * be able to query its view for the initialized paginator and sort.
     */
    ngAfterViewInit() {
      this.dataSourceSigns.paginator = this.paginatorSigns;
    }

    applyFilter(filterValue: string) {
      filterValue = filterValue.trim(); // Remove whitespace
      filterValue = filterValue.toLowerCase(); // Datasource defaults to lowercase matches
      this.dataSourceSigns.filter = filterValue;
    }

    addNew(): void {
      const dialogRef = this.dialog.open(NewSignalDialog, {
        // width: '250px',
        // data: { name: this.name, animal: this.animal }
      });

      dialogRef.afterClosed().subscribe(result => {
        console.log('The dialog was closed');
        // this.animal = result;
      });
    }

    removeSign() {
        // const res: boolean = this.groupService.removeSign(this.expandedElement);
        if (true) {// res) {
            // this.dataSourceSigns._updateChangeSubscription();
            this.snackBar.open('Сигнал на монету ' + this.expandedElement.coin + ' удален.', 'Вернуть', {
                duration: 3000,
            });
            this.expandedElement = null;
        }
    }
    dismissRemove() {
        this.expandedElement = null;
    }

  }

  function randomDate(start, end) {
    return new Date(start.getTime() + Math.random() * (end.getTime() - start.getTime()));
  }

  /** Builds and returns a new User. */
  function createNewUser(id: number): Signal {
    const name =
        NAMES[Math.round(Math.random() * (NAMES.length - 1))];

    return {
      id: id,
      title: 'Заголовок',
      coin: name,
      date: randomDate(new Date(2012, 0, 1), new Date()),
      target: {
        period: Period.Short,
        buy: 'fasf',
        profits: ['ads', 'dqw' ],
        stop: 'asff',
        },
      attachment: null,
      body: 'dasfdaf',
      status: SignalLevel[SignalLevel[Math.round(Math.random() * 2)]]
    };
  }

  /** Constants used to fill up our data base. */
  const NAMES = ['BTC', 'BTG', 'COIN', 'XMR', 'XPR', 'BNB',
    'ETH', 'ETC', 'MON', 'FLA', 'FUL', 'CTG',
    'WID', 'TRIG', 'PIT', 'POW', 'HTML', 'NPR', 'NIP'];
