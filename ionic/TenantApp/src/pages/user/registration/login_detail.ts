import { Component } from "@angular/core";
import { NavController, Tabs, Tab } from "ionic-angular";
import { ILoginDetail } from "../../../services/ILoginDetail";
import {  TenantApiService } from "../../../services/TenantApiService";

@Component({templateUrl:"./login_detail.html"})
export class LoginDetailPage{
    logindetail:ILoginDetail;

    username:string;
    password:string;
    confirmpass:string;
    shortname:string;
    captcha:string;

   constructor(private _navCrtl:NavController,private _tenantService:TenantApiService){

   }

   goToSubscriptionDetails(){
       this.bindLoginDetails();

       var t:Tabs=this._navCrtl.parent;
       var subscriptionTab:Tab = t.getByIndex(2);
       subscriptionTab.enabled=true; 
       t.select(2);
   }


   bindLoginDetails(){
        this.logindetail={
            username:this.username,
            password:this.password,
            shortname:this.shortname,
            captcha:this.captcha
        }
        this._tenantService.bindLoginDetails(this.logindetail);

       
   }




}