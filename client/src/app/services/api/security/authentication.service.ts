import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { User } from '../../../models/user';
import { BehaviorSubject } from 'rxjs';
import { JwtHelperService } from '@auth0/angular-jwt';
import { Router } from '@angular/router';
import { DataApiService } from '../data-api.service';

@Injectable()
export class AuthenticationService {
    private profile: User | null;
    private profileChange: BehaviorSubject<User>;

    constructor(
        private apiService: DataApiService,
        private jwtService: JwtHelperService,
        private router: Router) {
        this.profileChange = new BehaviorSubject<User | null>(this.profile);
        // if(this.jwtService.isTokenExpired()) {
        //     this.logout();
        //     return;
        // }
        // TODO: uncomment
        this.profile = JSON.parse(localStorage.getItem('profile'));
        if(!this.profile) {
            this.logout();
            return;
        }
        this.profileChange.next(this.profile);
    }

    getProfile(): BehaviorSubject<User> {
        return this.profileChange;
    }

    public async login(email: string, password: string) {

        let cred = await this.apiService.authorizate(email, password);
            // login успешно, если в ответе есть токен jwt
        if (!cred) return false;
        // сохраняем токен jwt в локальном хранилище
        localStorage.setItem('token', JSON.stringify(cred));
        localStorage.setItem('email', JSON.stringify(email));

        this.profile = <User> await this.apiService.getUsers(email).toPromise();
        if (!this.profile) return false;
        this.profileChange.next(this.profile);
        localStorage.setItem('profile', JSON.stringify(this.profile));

        return true;
    }

    public logout() {
        localStorage.clear();
        this.profile = null;
        this.profileChange.next(this.profile);
        this.router.navigate(['/home']);
    }

}
