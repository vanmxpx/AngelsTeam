import { ITarget } from './target';
import { SignalLevel } from './signalStatus';

export interface Signal {
    Id: string;
    Date: string;
    Coin: string;
    Target: ITarget;
    Status: SignalLevel;
    Description: string;
    Attachment: string;
}
