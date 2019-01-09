export interface Subscription {
    name: string;
    price: number;
    exchange: string;
    duration: SubscriptionDuration;
}

export enum SubscriptionDuration {
    Mounth = 1, Year = 12, Infinity = Number.POSITIVE_INFINITY
}
