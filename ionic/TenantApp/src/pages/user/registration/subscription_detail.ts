import { Component } from "@angular/core";
import {  TenantApiService } from "../../../services/TenantApiService";
import { ISubscriptionDetail } from "../../../services/ISubscriptionDetail";

import { LoginPage } from "../login/login";
import { NavController, App } from "ionic-angular";


@Component({templateUrl:"./subscription_detail.html"})
export class SubscriptionDetailPage{
    subscriptionDetail:ISubscriptionDetail;

    subscriptionType:string;
    noOfNamedUser:number;
    modules:string[];
    services:string[];

    constructor(private _tenantService:TenantApiService,private _navCtrl:NavController,private _app:App){
      
    }


    goToLoginPage(){

         this.bindSubscriptionDetail();
        // console.log("approve clicked..");
        // for( let i=0;i<this.modules.length;i++){
        //     console.log(this.modules[i]);
        // }

        this._tenantService.registerUser()
        .then((r)=>{console.log("data inserted..")})
        .catch((e)=>console.log("Error while inserting.."));

        this._app.getRootNavs()[0].setRoot(LoginPage);
        

        
      
    
     
       
    }

    bindSubscriptionDetail(){
        this.subscriptionDetail={
            type:this.subscriptionType,
            noOfNamedUser:this.noOfNamedUser,
            modules:this.modules,
            services:this.services

        }

        this._tenantService.bindSubscriptionDetails(this.subscriptionDetail);

      
    }

  

}