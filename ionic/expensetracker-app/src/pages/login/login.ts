import { Component } from "@angular/core";
import { Iuser } from "../../services/Iuser";
import { AuthenticationService } from "../../services/AuthenticationService";
import { NavController } from "ionic-angular";
import { HomePage } from "../home/home";

@Component({templateUrl:"./login.html"})
export class LoginPage{

   username:string;
   password:string;

   constructor(private _authService:AuthenticationService,private _navCtrl:NavController){
       this.username="";
       this.password="";
   }


   login(){
      if(this._authService.authenticateUSer(this.username,this.password)){
        console.log("login successfull....");
         this._navCtrl.setRoot(HomePage);
      }
      
   }


}