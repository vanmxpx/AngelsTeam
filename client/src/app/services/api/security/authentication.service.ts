import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { User } from '../../../models/user';
import { DataApiMockService } from '../data-api-mock.service';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
  })
};

@Injectable()
export class AuthenticationService {
   private profile: User;

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private url: string,
    private apiService: DataApiMockService) { }

  public async login(login: string, password: string) {

    let cred = await this.apiService.authorizate(login, password);
        // login успешно, если в ответе есть токен jwt
    if (!cred) return false;
    // сохраняем токен jwt в локальном хранилище
    localStorage.setItem('token', JSON.stringify(cred));
    localStorage.setItem('login', JSON.stringify(login));
    this.profile = await this.apiService.getUser(login);
    localStorage.setItem('profile', JSON.stringify(this.profile));

    return false;
  }

  public logout() {
    localStorage.clear();
  }

}
