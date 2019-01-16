import { Period } from './signal-status';

export interface Target {
    period: Period;
    buy: string;
    profits: string[];
    stop: string;
}
