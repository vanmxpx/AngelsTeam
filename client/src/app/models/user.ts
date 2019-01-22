import { Subscription } from './subscription';

export interface User {
    id: number;
    name: string;
    surname: string;
    telegram: string;
    photo?: string;
    subscriptions: Subscription[];
    expirationDate: Date;
    userType: UserType;
  }

  export enum UserType {
      Admin = 1, User = 2, Free = 3, Unveryfied = 4 
  }
