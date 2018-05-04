import { Period } from './signalStatus';

export interface ITarget {
    Period: Period;
    Buy: string;
    Profits: string[];
    Stop: string;
    Description: string;
}
