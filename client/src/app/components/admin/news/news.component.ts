import { Component, ViewChild, AfterViewInit, OnInit } from '@angular/core';

import {MatPaginator, MatSort, MatTableDataSource, MatDialog, MatSnackBar} from '@angular/material';
import { trigger, style, transition, state, animate } from '@angular/animations';
import { User, UserType } from '../../../models/user';
import { SubscriptionDuration } from '../../../models/subscription';
@Component({
    selector: 'news',
    templateUrl: './news.component.html',
    styleUrls: ['./news.component.scss'],
    animations: [
      trigger('detailExpand', [
        state('void', style({ height: '0px', minHeight: '0', visibility: 'hidden' })),
        state('*', style({ height: '*', visibility: 'visible' })),
        transition('void <=> *', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
      ])
    ],
})
export class NewsComponent implements OnInit, AfterViewInit {

    users: User[] = [];
    newUsers: number = 10;
    // Details
    expandedElement: any;

    // Table
    displayedColumns = ['Id', 'Name', 'Contact', 'Sub', 'SubLeft', 'NewUser', 'Edit', 'Remove'];
    dataSourceSubs: MatTableDataSource<User>;
    @ViewChild('paginatorSubs') paginatorSubs: MatPaginator;
    @ViewChild('sortSubs') sortSubs: MatSort;

    constructor(public snackBar: MatSnackBar, public dialog: MatDialog) { }

    ngOnInit(): void {
      this.loadUsers();
    }

    ngAfterViewInit() {
      this.dataSourceSubs.paginator = this.paginatorSubs;
      this.dataSourceSubs.sort = this.sortSubs;
    }
    apply(row: User): void {
      row.userType = UserType.Usual;
    }

    applyFilter(filterValue: string) {
      filterValue = filterValue.trim(); // Remove whitespace
      filterValue = filterValue.toLowerCase(); // Datasource defaults to lowercase matches
      this.dataSourceSubs.filter = filterValue;
    }

    loadUsers(): void {
      // Create 100 users

      for (let i = 1; i <= 54; i++) { this.users.push(createNewUser1(i)); }

      // Assign the data to the data source for the table to render
      this.dataSourceSubs = new MatTableDataSource(this.users);
    }
  }

  /** Builds and returns a new User. */
  function createNewUser1(id: number): User {
    const name =
        NAMES1[Math.round(Math.random() * (NAMES1.length - 1))] + ' ' +
        NAMES1[Math.round(Math.random() * (NAMES1.length - 1))].charAt(0) + '.';
    const sub = COLORS1[Math.round(Math.random() * (COLORS1.length - 1))];
    const newUser = sub === 'FREE' ? false : Math.round(Math.random() * 2) === 2;
    const subLeft = newUser || sub === 'FREE' || sub === 'UNLIMIT' ? 0 : Math.round(Math.random() * 30);
    return {
      id: id,
      name: name,
      Contact: Math.round(Math.random() * 100).toString(),
      subscription: { id: 0, description:[''], duration: SubscriptionDuration.Mounth, exchange: 'BTC', name: 'test', price:1   },
      subLeft: subLeft,
      userType: newUser ? UserType.Unveryfied : UserType.Usual
    };
  }

  /** Constants used to fill up our data base. */
  const COLORS1 = ['FREE', 'MOUNTH', 'UNLIMIT'];
  const NAMES1 = ['Maia', 'Asher', 'Olivia', 'Atticus', 'Amelia', 'Jack',
    'Charlotte', 'Theodore', 'Isla', 'Oliver', 'Isabella', 'Jasper',
    'Cora', 'Levi', 'Violet', 'Arthur', 'Mia', 'Thomas', 'Elizabeth'];
