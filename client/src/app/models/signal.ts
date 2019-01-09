import { ITarget } from './target';
import { SignalStatus } from './signalStatus';

export interface Signal {
    Id: string;
    Date: string;
    Coin: string;
    Target: ITarget;
    Status: SignalStatus;
    Description: string;
}
