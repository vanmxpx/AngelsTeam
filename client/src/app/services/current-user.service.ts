import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable()
export class CurrentUserService {
    private _autorized: boolean;
    private _autoricationChange: BehaviorSubject<boolean>;

    constructor() {
        this._autoricationChange = new BehaviorSubject<boolean>(this._autorized);
    }

    getAutorized(): BehaviorSubject<boolean> {
        return this._autoricationChange;
    }
}
