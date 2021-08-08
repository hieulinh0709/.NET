import { Component, OnInit, Input } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {

  form: any = {};
  isLoggedIn = false;
  isLoginFailed = false;
  errorMessage = '';
  roles: string[] = [];

  constructor(private service:SharedService, private router:Router) { }

  @Input() login:any;

  ngOnInit(): void {
  }

  postLogin(){
    this.service.login(this.form).subscribe(res=>{
      console.log(res)
      console.log(res.token)
      this.service.saveToken(res.token);
      this.service.saveUser(res)
      

      this.isLoginFailed = false;
      this.isLoggedIn = true;
      //this.roles = this.service.getUser().roles;
      //this.reloadPage();
      this.router.navigate(['/home'])
    });
  }

  reloadPage(): void {
    window.location.reload();
  }

}
