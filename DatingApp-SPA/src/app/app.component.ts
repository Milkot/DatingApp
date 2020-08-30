import { Component, OnInit } from '@angular/core';
import { AuthService } from './_services/auth.service';
import { JwtHelperService } from '@auth0/angular-jwt';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Beetic';
  jwtHelper = new JwtHelperService();

  constructor(private authService: AuthService) {}

  ngOnInit() {

    // Permet de décoder et d'accèder au token JWT à chaque chargement de l'appli
    // Authentification ++
    const token = localStorage.getItem('token');
    if (token)
    {
      this.authService.decodedToken = this.jwtHelper.decodeToken(token);
    }
  }
}
