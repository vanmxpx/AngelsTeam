import { Subscription } from './subscription';

export interface User {
    id: number;
    name: string;
    contact: string;
    photo?: string;
    subscription: Subscription;
    subLeft: number;
    userType: UserType;
  }

  export enum UserType {
      Unveryfied, Usual, Admin
  }
