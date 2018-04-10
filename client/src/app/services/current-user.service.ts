import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';

@Injectable()
export class CurrentUserService {
    private _autorized: boolean;
    private _name: string;
    private _nameChange: BehaviorSubject<string>;
    private _autoricationChange: BehaviorSubject<boolean>;

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
            return true;
        }
        return false;
    }
}
