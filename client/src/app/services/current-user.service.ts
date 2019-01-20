import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable()
export class CurrentUserService {
    private _autorized: boolean;
    private _login: string;
    private _loginChange: BehaviorSubject<string>;
    private _autoricationChange: BehaviorSubject<boolean>;

    constructor() {
        this._loginChange = new BehaviorSubject<string>(this._login);
        this._autoricationChange = new BehaviorSubject<boolean>(this._autorized);
    }
    getLogin(): BehaviorSubject<string> {
        return this._loginChange;
    }

    getAutorized(): BehaviorSubject<boolean> {
        return this._autoricationChange;
    }

    autorize(login: string, pass: string): boolean {
        if ((login === 'admin' && pass === 'admin') ||
            (login === 'user' && pass === 'user')) {
            this._login = login;
            this._loginChange.next(this._login);
            this._autoricationChange.next(true);
            return true;
        }
        this._autoricationChange.next(false);
        return false;
    }
}
