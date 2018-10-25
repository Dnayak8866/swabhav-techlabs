import { Component } from "@angular/core";
import { LoginService } from "./services/LoginService";
import { Router, ActivatedRoute } from "@angular/router";

@Component({templateUrl:"./login.component.html"})
export class LoginComponent{
    userid:string;
    password:string;
    
    contactname:string;

    constructor(private _loginService:LoginService,private _router:Router,private _routes:ActivatedRoute){
        this._routes.params.subscribe(params=>this.contactname=params.name);
        
        if(_loginService.loggedInUser!=null){
            this._router.navigate(['edit',{name:this.contactname}]);
        }
    }
    checkUser(){
        if(this._loginService.authenticateUser(this.userid,this.password)){
            console.log("inside logincompo...");
            this._router.navigate(['Home']);
        }
    }
}