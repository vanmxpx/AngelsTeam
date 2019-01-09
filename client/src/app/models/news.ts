import { ITarget } from './target';
import { SignalLevel } from './signalStatus';

export interface News {
    id: string;
    date: string;
    description: string;
    attachment: string;
}
