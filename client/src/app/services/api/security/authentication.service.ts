import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { User } from '../../../models/user';
import { DataApiMockService } from '../data-api-mock.service';
import { BehaviorSubject } from 'rxjs';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
  })
};

@Injectable()
export class AuthenticationService {
    private profile: User;
    private profileChange: BehaviorSubject<User>;

    constructor(
        private apiService: DataApiMockService) {
        this.profileChange = new BehaviorSubject<User>(this.profile);
    }

    getProfile(): BehaviorSubject<User> {
        return this.profileChange;
    }

    public async login(login: string, password: string) {

        let cred = await this.apiService.authorizate(login, password);
            // login успешно, если в ответе есть токен jwt
        if (!cred) return false;
        // сохраняем токен jwt в локальном хранилище
        localStorage.setItem('token', JSON.stringify(cred));
        localStorage.setItem('login', JSON.stringify(login));

        this.profile = await this.apiService.getUser(login);
        if (!this.profile) return false;
        this.profileChange.next(this.profile);
        localStorage.setItem('profile', JSON.stringify(this.profile));

        return true;
    }

    public logout() {
        localStorage.clear();
    }

}
