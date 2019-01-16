import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Credentials } from '../models/credentials';
import { Signal } from '../models/Signal';
import { News } from '../models/news';
import { User } from '../models/user';
import { Subscription } from '../models/subscription';

@Injectable()
export class DataApiService {

    constructor(
        private http: HttpClient,
        @Inject('BASE_URL') private url: string) {

    }

    public getSubscriptions(): Promise<Subscription[]> {
        return this.http
            .get<Subscription[]>(`${this.url}subscription`).toPromise();
    }
    // public getSignals(userCred: Credentials): Promise<Signal[]> {
    //     return this.http
    //         .get<Signal[]>(`${this.url}signal`, { params: userCred}).toPromise();
    // }
    public getNews(): Promise<News[]> {
        return this.http
            .get<News[]>(`${this.url}news`).toPromise();
    }
    public getUsers(): Promise<User[]> {
        return this.http
            .get<User[]>(`${this.url}user`).toPromise();
    }
    public updateSignal(signal: Signal, userCred: Credentials): Promise<Signal> {
        return this.http
            .post<Signal>(`${this.url}signal`, { signal: signal, userCred: userCred }).toPromise();
    }
    public updateNews(news: News, userCred: Credentials): Promise<News> {
        return this.http
            .post<News>(`${this.url}news`, { news: news, userCred: userCred }).toPromise();
    }
    public updateUser(user: User, userCred: Credentials): Promise<User> {
        return this.http
            .post<User>(`${this.url}user`, { user: user, userCred: userCred }).toPromise();
    }
    public registerUser(user: User, userCred: Credentials): Promise<User> {
        return this.http
            .post<User>(`${this.url}auth/register`, { user: user, userCred: userCred }).toPromise();
    }

    public authorizate(login: string, password: string): Promise<Credentials> {
        return this.http
            .post<Credentials>(`${this.url}auth`, { login: login, password: password }).toPromise();
    }

}
