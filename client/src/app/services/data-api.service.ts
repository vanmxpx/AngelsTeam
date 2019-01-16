import { Injectable, Inject } from '@angular/core';
import { Subscription } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Credentials } from '../models/credentials';
import { Signal } from '../models/Signal';
import { News } from '../models/news';
import { User } from '../models/user';

@Injectable()
export class DataApiService {

    constructor(
        private http: HttpClient,
        @Inject('BASE_URL') private url: string) {

    }

    public async getSubscriptions() {
        return await this.http
            .get<Subscription[]>(`${this.url}subscription`).toPromise();
    }
    public async getSignals(userCred: Credentials) {
        // return await this.http
        //     .get<Signal[]>(`${this.url}signal`, { params: userCred}).toPromise();
    }
    public async getNews() {
        return await this.http
            .get<News[]>(`${this.url}news`).toPromise();
    }
    public async getUsers() {
        return await this.http
            .get<User[]>(`${this.url}user`).toPromise();
    }
    public async updateSignal(signal: Signal, userCred: Credentials) {
        return await this.http
            .post<Signal>(`${this.url}signal`, { signal: signal, userCred: userCred }).toPromise();
    }
    public async updateNews(news: News, userCred: Credentials) {
        return await this.http
            .post<News>(`${this.url}news`, { news: news, userCred: userCred }).toPromise();
    }
    public async updateUser(user: User, userCred: Credentials) {
        return await this.http
            .post<User>(`${this.url}user`, { user: user, userCred: userCred }).toPromise();
    }
    public async registerUser(user: User, userCred: Credentials) {
        return await this.http
            .post<User>(`${this.url}auth/register`, { user: user, userCred: userCred }).toPromise();
    }

    public async authorizate(login: string, password: string) {
        return await this.http
            .post<Credentials>(`${this.url}auth`, { login: login, password: password }).toPromise();
    }

}
