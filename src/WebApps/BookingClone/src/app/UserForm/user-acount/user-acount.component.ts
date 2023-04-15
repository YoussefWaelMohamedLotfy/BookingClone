import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
interface loginData {
  email: string,
  password: string,
  address:string
}
interface loginUserData {
  email: string,
  password: string,
  address:string
}
@Component({
  selector: 'app-user-acount',
  templateUrl: './user-acount.component.html',
  styleUrls: ['./user-acount.component.css']
})
export class UserAcountComponent implements OnInit{
  loginForm!: FormGroup;
  users: Array<loginData>=[];
  curruntemail:string=''
  loginuser:any
  ifLogin:boolean=false
  user: any;

    constructor(private router: Router) {


      console.log("this.users");
      console.log(this.users);
      this.loginForm = new FormGroup({
        email: new FormControl('', [Validators.required]),
        password: new FormControl('', [Validators.required]),
        address:new FormControl('')
      });
    }
  ngOnInit(): void {

    let x = localStorage.getItem("users");
    if (x !== null && x !== '')
      this.users = JSON.parse(x);
    else {
      this.users = [];
    }
    console.log('uuusers',this.users)
    this.loginuser= JSON.parse(localStorage.getItem("ifLogin")!);
       if(this.loginuser){

        this.loginForm.setValue({email:this.loginuser.email,password:this.loginuser.password,address:this.loginuser.address})
       }
  }
    updateData() {
      let email = this.loginForm.value.email;
      let password = this.loginForm.value.password;
      let address=this.loginForm.value.address
      if (this.loginForm.invalid) {
        alert("Please Insert Email and Password");
        return
      }
      else {

        this.user = this.users.find((item: loginData) =>
          item.email === this.loginuser.email
        );
        console.log('ddddddddddddddd',this.user)
        let index=this.users.findIndex(x=>x.email==this.user.email);
        this.users.splice(index, 1);
      }
this.user.email=email
this.user.password=password
this.user.address=address
this.users.push(this.user)
localStorage.setItem("users", JSON.stringify(this.users));
this.loginuser={email:email,password:password,address:address}
localStorage.setItem("ifLogin", JSON.stringify(this.loginuser))
alert("Account created successfully");


      }
    }

