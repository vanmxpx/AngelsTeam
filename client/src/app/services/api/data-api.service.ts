import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Signal } from '../../models/Signal';
import { News } from '../../models/news';
import { User } from '../../models/user';
import { Subscription } from '../../models/subscription';
import { Observable } from 'rxjs';

@Injectable()
export class DataApiService {

    constructor(
        private http: HttpClient,
        @Inject('BASE_URL') private url: string) {

    }

    public getSubscriptions(): Observable<Subscription[]> {
        return this.http
            .get<Subscription[]>(`${this.url}api/subscription`);
    }
    public getSignals(): Observable<Signal[]> {
        return this.http
            .get<Signal[]>(`${this.url}api/signal`);
    }
    public getNews(): Observable<News[]> {
        return this.http
            .get<News[]>(`${this.url}api/news`);
    }
    public getUsers(email?: string): Observable<User[] | User> {
        if (email)
            return this.http
                .get<User>(`${this.url}api/user`);
        else
            return this.http
                .get<User[]>(`${this.url}api/user`);
    }
    public updateSignal(signal: Signal): Observable<Signal> {
        return this.http
            .post<Signal>(`${this.url}api/signal`, { signal: signal });
    }
    public updateNews(news: News): Observable<News> {
        return this.http
            .post<News>(`${this.url}api/news`, { news: news });
    }
    public updateUser(user: User): Observable<User> {
        return this.http
            .post<User>(`${this.url}api/user`, { user: user });
    }
    public registerUser(user: User): Observable<User> {
        return this.http
            .post<User>(`${this.url}api/auth/register`, { user: user });
    }

    public authorizate(email: string, password: string): Observable<string> {
        return this.http
            .post<string>(`${this.url}api/auth`, { email: email, password: password });
    }

}
