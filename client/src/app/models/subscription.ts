export interface Subscription {
    id: number;
    name: string;
    price: number;
    exchange: string;
    duration: SubscriptionDuration;
    description: string[];
}

export enum SubscriptionDuration {
    Mounth = 1, Year = 12, Infinity = -1
}
