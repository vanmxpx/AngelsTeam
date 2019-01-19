import { Injectable } from '@angular/core';
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, CanLoad } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';

@Injectable()
export class AdminGuard implements CanLoad {

    constructor(
        private router: Router,
        public jwtHelper: JwtHelperService) { }

    canLoad() {
        const token = JSON.parse(localStorage.getItem('token'));

        if (!token) {
            this.router.navigate(['/home']);
            return false;
        }
        return true; // TODO: remove
        return !this.jwtHelper.isTokenExpired();
    }
}