import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable()
export class CurrentUserService {
    private _autorized: boolean;
    private _name: string;
    private _nameChange: BehaviorSubject<string>;
    private _autoricationChange: BehaviorSubject<boolean>;

    constructor() {
        this._nameChange = new BehaviorSubject<string>(this._name);
        this._autoricationChange = new BehaviorSubject<boolean>(this._autorized);
    }
    getName(): BehaviorSubject<string> {
        return this._nameChange;
    }

    getAutorized(): BehaviorSubject<boolean> {
        return this._autoricationChange;
    }

    autorize(login: string, pass: string): boolean {
        if ((login === 'admin' && pass === 'admin') ||
            (login === 'user' && pass === 'user')) {
            this._name = login;
            this._nameChange.next(this._name);
            return true;
        }
        return false;
    }
}
