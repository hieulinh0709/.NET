import { Component, OnInit } from '@angular/core';
import { SharedService } from '../shared.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  isLoggedIn = false;
  isLoginFailed = false;

  constructor(
    private service:SharedService,
    private router:Router) { }

  ngOnInit(): void {
    if (this.service.getToken() != null && this.service.getToken() != "{}") {
      this.isLoggedIn = true;
      alert("home get token ok: " + this.service.getToken())
    }
    else {
      
      alert("home get token no ok")
      this.router.navigate(["/"])
    }
  }

  logout(): void {
    this.service.signOut();
    window.location.reload();
  }
}
