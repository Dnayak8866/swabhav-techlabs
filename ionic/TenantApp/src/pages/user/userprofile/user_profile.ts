import { Component } from "@angular/core";
import { TenantApiService } from "../../../services/TenantApiService";

@Component({templateUrl:"./user_profile.html"})
export class UserProfilePage{

    loginid:string;
    constructor(private _tenantService:TenantApiService){

        if(localStorage.getItem("loginid")!=null){
           // console.log(this.loginid=localStorage.getItem("loginid"));
            this.loginid=localStorage.getItem("loginid");

            
            this._tenantService.getUserById(localStorage.getItem("loginid"))
                .then((r)=>console.log("User ",r.json()))
                .catch((e)=>console.log("error while fetching user..."));
        }
    }
}