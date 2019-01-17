import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Signal } from '../../models/Signal';
import { News } from '../../models/news';
import { User, UserType } from '../../models/user';
import { Subscription, SubscriptionDuration } from '../../models/subscription';
import { Period, SignalLevel } from '../../models/signal-status';

@Injectable()
export class DataApiMockService {

    constructor(
        private http: HttpClient,
        @Inject('BASE_URL') private url: string) {

    }

    public getSubscriptions(): Promise<Subscription[]> {
        return new Promise((resolve, reject) => {
            let values: Subscription[] = [{
                id: 1, name: 'Mounth', price: 10, exchange: 'BTC', duration: SubscriptionDuration.Mounth,
                description: ['Ознакомление с контентом', 'Бесплатные сигналы', 'Разборы некоторых монет']
            },
            {
                id: 2, name: 'Year', price: 20, exchange: 'BTC', duration: SubscriptionDuration.Year,
                description: ['Приватные сигналы', 'Приватный чат участников', 'Продление подписки, если месячный профит составил < 60%']
            },
            {
                id: 3, name: 'Free', price: 0, exchange: '', duration: SubscriptionDuration.Infinity,
                description: ['Разбор Ваших монет', 'Личные консультации', 'Безлимитные сигналы']
            }];
            resolve(values);
        });
    }
    public getSignals(): Promise<Signal[]> {
        let signalsLEvel: string[] = ['hight', 'middle', 'low', 'info']
        return new Promise((resolve, reject) => {
            let values: Signal[] = [];
            for (let id = 1; id < 15; id++) {
                values.push({
                    id: id,
                    title: 'Сигнал дня',
                    coin: this.NAMES[Math.round(Math.random() * (this.NAMES.length - 1))],
                    date: this.randomDate(new Date(2012, 0, 1), new Date()),
                    target: {
                        period: Period.Short,
                        buy: 'fasf',
                        profits: ['ads', 'dqw'],
                        stop: 'asff',
                    },
                    attachment: 'assets/images/test.jpeg',
                    body: 'Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам:',
                    status: <SignalLevel>signalsLEvel[Math.round(Math.random() * 3)]
                });
            }
            resolve(values);
        });


        // if (userCred.token === 'admin'){
        //     return new Promise((resolve, reject) => {
        //         resolve([]);
        //     });
        // } else {
        //     return new Promise((resolve, reject) => {
        //         resolve();
        //     });
        // }
    }
    public getNews(): Promise<News[]> {
        return new Promise((resolve, reject) => {
            let values: News[] = [
                { id: 1, date: this.randomDate(new Date(2012, 0, 1), new Date()), title: 'Новость дня', body: 'Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам:', attachment: 'assets/images/test.jpeg', likes: 20, dislikes: 10},
                { id: 2, date: this.randomDate(new Date(2012, 0, 1), new Date()), title: 'Новость дня', body: 'Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам:', attachment: 'assets/images/test.jpeg', likes: 20, dislikes: 10},
                { id: 3, date: this.randomDate(new Date(2012, 0, 1), new Date()), title: 'Новость дня', body: 'Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам:', attachment: 'assets/images/test.jpeg', likes: 20, dislikes: 10},
                { id: 4, date: this.randomDate(new Date(2012, 0, 1), new Date()), title: 'Новость дня', body: 'Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс "Начинающий трейдер". У нас хорошие новости. Освободилось ровно три места. По всем вопросам:', attachment: 'assets/images/test.jpeg', likes: 20, dislikes: 10},
            ];
            resolve(values);
        });
    }
    public getAllUsers(): Promise<User[]> {
        return new Promise((resolve, reject) => {
            resolve();
        });
    }
    public getUser(login: string): Promise<User> {
        return new Promise((resolve, reject) => {
            if (login === 'admin'){
                resolve({ userType: UserType.Admin, name: '', Contact: '', id: 0, subscription: this.getSubscriptions()[0], subLeft: 0});

            } else {
                resolve({ userType: UserType.Usual, name: '', Contact: '', id: 0, subscription: this.getSubscriptions()[0], subLeft: 0});
            }
        });
    }
    public updateSignal(signal: Signal): Promise<Signal> {
        return new Promise((resolve, reject) => {
            resolve();
        });
    }
    public updateNews(news: News): Promise<News> {
        return new Promise((resolve, reject) => {
            resolve();
        });
    }
    public updateUser(user: User): Promise<User> {
        return new Promise((resolve, reject) => {
            resolve();
        });
    }
    public registerUser(user: User): Promise<User> {
        return new Promise((resolve, reject) => {
            resolve();
        });
    }

    public authorizate(login: string, password: string): Promise<string> {
        return new Promise((resolve, reject) => {
            if (login === 'admin' && password === 'admin'){
                resolve('admin');
            } else {
                resolve('123');
            }
        });
    }
randomDate(start: Date, end: Date): Date {
    return new Date(start.getTime() + Math.random() * (end.getTime() - start.getTime()));
}

/** Constants used to fill up our data base. */
NAMES = ['BTC', 'BTG', 'COIN', 'XMR', 'XPR', 'BNB',
    'ETH', 'ETC', 'MON', 'FLA', 'FUL', 'CTG',
    'WID', 'TRIG', 'PIT', 'POW', 'HTML', 'NPR', 'NIP'];
}
