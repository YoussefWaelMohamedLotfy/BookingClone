import { Component } from '@angular/core';
import { FormControl, FormGroup, FormsModule, Validators} from '@angular/forms';
import { Router } from '@angular/router';
import { LocalizationServiceService } from 'src/app/Shared/Services/localization-service.service';
interface loginData {
  email: string,
  address:string,
  password: string
}
interface loginUserData {
  email: string,
  address:string,
  password: string
}
@Component({
  selector: 'app-forms',
  templateUrl: './forms.component.html',
  styleUrls: ['./forms.component.css']
})
export class FormsComponent {

  loginForm!:FormGroup;
  users: Array<loginData>;
  loginUser:any
  filterUsers: Array<loginData> = [];
  constructor(private router: Router) {
    let x = localStorage.getItem("users");
    if (x !== null && x !== '')
      this.users = JSON.parse(x);
    else {
      this.users = [];
    }
    console.log("this.users");
    console.log(this.users);

  }
  ngOnInit(): void {
    //Called after the constructor, initializing input properties, and the first call to ngOnChanges.
    //Add 'implements OnInit' to the class.
    this.loginForm = new FormGroup({
      email: new FormControl('', [Validators.required]),
      password: new FormControl('', [Validators.required]),
      address:new FormControl(' ')
    });

  }

  login() {
    let email = this.loginForm.value.email;
    let password = this.loginForm.value.password;



    this.filterUsers = this.users.filter((item: loginData) => item.email == email);


    if (this.filterUsers.length == 0) {
      alert("Invaild email");
    }
    else if (this.filterUsers[0].password == password) {
      console.log("login successfully");
      this.loginUser={email:email,password:password,address:this.filterUsers[0].address}
      localStorage.setItem("ifLogin", JSON.stringify(this.loginUser))
      this.router.navigate(['Stays']); // stays
    }
    else {
      alert("invaild password");
      localStorage.setItem("ifLogin","")
    }
  }


  Register() {

    if (this.loginForm.invalid) {
      alert("Please Insert Email and Password");
      return
    }
    else {

      this.filterUsers = this.users.filter((item: loginData) =>
        item.email === this.loginForm.controls['email'].value
      );
      if (this.filterUsers.length > 0) {
        alert("This email already has an account");
      }
      else {
        this.users.push(this.loginForm.value);
        localStorage.setItem("users", JSON.stringify(this.users));
        alert("Account created successfully");
        this.router.navigate(['Stays']); // stays
      }
    }
  }


}
