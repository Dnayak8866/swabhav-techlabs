import { Component } from "@angular/core";
import { NavController } from "ionic-angular";
import { MenuPage } from "../../menupage/menu";
import { LoginService } from "../../../services/LoginService";

@Component ({templateUrl:"./login.html"})
export class LoginPage{

    username:string;
    password:string;

    constructor(private _navCtrl:NavController,private _loginService:LoginService){
       
    }

    login(){
        this._loginService.authenticateUser(this.username,this.password)
            .then((r)=>{
                console.log(r);
                console.log("inside then..");
                console.log(r.json());
                if(r.json()!="cancel"){
                    console.log("inside ...");

                    localStorage["loginid"]=r.json();
                    this._navCtrl.setRoot(MenuPage);
                }
                
            });

            
           

       
    }

}