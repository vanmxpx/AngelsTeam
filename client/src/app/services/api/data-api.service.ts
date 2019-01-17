import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Signal } from '../../models/Signal';
import { News } from '../../models/news';
import { User } from '../../models/user';
import { Subscription } from '../../models/subscription';

@Injectable()
export class DataApiService {

    constructor(
        private http: HttpClient,
        @Inject('BASE_URL') private url: string) {

    }

    public getSubscriptions(): Promise<Subscription[]> {
        return this.http
            .get<Subscription[]>(`${this.url}api/subscription`).toPromise();
    }
    // public getSignals(userCred: Credentials): Promise<Signal[]> {
    //     return this.http
    //         .get<Signal[]>(`${this.url}api/signal`, { params: userCred}).toPromise();
    // }
    public getNews(): Promise<News[]> {
        return this.http
            .get<News[]>(`${this.url}api/news`).toPromise();
    }
    public getUsers(): Promise<User[]> {
        return this.http
            .get<User[]>(`${this.url}api/user`).toPromise();
    }
    public updateSignal(signal: Signal): Promise<Signal> {
        return this.http
            .post<Signal>(`${this.url}api/signal`, { signal: signal }).toPromise();
    }
    public updateNews(news: News): Promise<News> {
        return this.http
            .post<News>(`${this.url}api/news`, { news: news }).toPromise();
    }
    public updateUser(user: User): Promise<User> {
        return this.http
            .post<User>(`${this.url}api/user`, { user: user }).toPromise();
    }
    public registerUser(user: User): Promise<User> {
        return this.http
            .post<User>(`${this.url}api/auth/register`, { user: user }).toPromise();
    }

    public authorizate(login: string, password: string): Promise<string> {
        return this.http
            .post<string>(`${this.url}api/auth`, { login: login, password: password }).toPromise();
    }

}
