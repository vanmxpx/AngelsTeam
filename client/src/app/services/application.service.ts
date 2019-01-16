import { Injectable, OnDestroy } from '@angular/core';
import { ChangeDetectorRef } from '@angular/core';
import { MediaMatcher } from '@angular/cdk/layout';
import { BehaviorSubject } from 'rxjs';
import { ApplicationRef } from '@angular/core';

@Injectable()
export class ApplicationService implements OnDestroy {

    private _mobileQuery: MediaQueryList;
    private _mobileQueryChange: BehaviorSubject<MediaQueryList>;
    private _mobileQueryListener: () => void;
    private count: number = 0;

     constructor(ref: ApplicationRef, media: MediaMatcher) {
        this._mobileQuery = media.matchMedia('(max-width: 600px)');
         this._mobileQueryChange = new BehaviorSubject<MediaQueryList>(this._mobileQuery);

         this._mobileQueryListener = () => {
            ref.tick();
            this._mobileQueryChange.next(this._mobileQuery);

         };
         this._mobileQuery.addListener(this._mobileQueryListener);
    }

    getMobileQuery(): BehaviorSubject<MediaQueryList> {
        return this._mobileQueryChange;
    }
    ngOnDestroy(): void {
      this._mobileQuery.removeListener(this._mobileQueryListener);
    }
}
