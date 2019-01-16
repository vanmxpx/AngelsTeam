import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Credentials } from '../models/credentials';
import { Signal } from '../models/Signal';
import { News } from '../models/news';
import { User } from '../models/user';
import { Subscription, SubscriptionDuration } from '../models/subscription';

@Injectable()
export class DataApiMockService {

    constructor(
        private http: HttpClient,
        @Inject('BASE_URL') private url: string) {

    }

    public getSubscriptions(): Promise<Subscription[]> {
        return new Promise((resolve, reject) => {
            let values: Subscription[] = [{
                name: 'Mounth', price: 10, exchange: 'BTC', duration: SubscriptionDuration.Mounth,
                description: ['Ознакомление с контентом', 'Бесплатные сигналы', 'Разборы некоторых монет']
            },
            {
                name: 'Year', price: 20, exchange: 'BTC', duration: SubscriptionDuration.Year,
                description: ['Приватные сигналы', 'Приватный чат участников', 'Продление подписки, если месячный профит составил < 60%']
            },
            {
                name: 'Free', price: 0, exchange: '', duration: SubscriptionDuration.Infinity,
                description: ['Разбор Ваших монет', 'Личные консультации', 'Безлимитные сигналы']
            }];
            resolve(values);
        });
    }
    public getSignals(userCred: Credentials): Promise<Signal[]> {
        return new Promise((resolve, reject) => {
            resolve();
        });
    }
    public getNews(): Promise<News[]> {
        return new Promise((resolve, reject) => {
            resolve();
        });
    }
    public getUsers(): Promise<User[]> {
        return new Promise((resolve, reject) => {
            resolve();
        });
    }
    public updateSignal(signal: Signal, userCred: Credentials): Promise<Signal> {
        return new Promise((resolve, reject) => {
            resolve();
        });
    }
    public updateNews(news: News, userCred: Credentials): Promise<News> {
        return new Promise((resolve, reject) => {
            resolve();
        });
    }
    public updateUser(user: User, userCred: Credentials): Promise<User> {
        return new Promise((resolve, reject) => {
            resolve();
        });
    }
    public registerUser(user: User, userCred: Credentials): Promise<User> {
        return new Promise((resolve, reject) => {
            resolve();
        });
    }

    public authorizate(login: string, password: string): Promise<Credentials> {
        return new Promise((resolve, reject) => {
            resolve();
        });
    }

}
