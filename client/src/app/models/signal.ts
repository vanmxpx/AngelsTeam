import { Target } from './target';
import { SignalLevel } from './signal-status';

export interface Signal {
    id: string;
    date: string;
    coin: string;
    target: Target;
    status: SignalLevel;
    body: string;
    attachment: string;
}
