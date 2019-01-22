import { Target } from './target';
import { SignalLevel } from './signal-status';

export interface Signal {
    id: number;
    free?: boolean;
    title: string;
    date: Date;
    coin: string;
    body: string;
    attachment: string;
    target: Target;
    status: SignalLevel;
}
