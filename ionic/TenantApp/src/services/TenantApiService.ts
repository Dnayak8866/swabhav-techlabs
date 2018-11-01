import { IUser } from "./IUser";
import { IBasicDetail } from "./IBasicDetail";
import { ILoginDetail } from "./ILoginDetail";
import { ISubscriptionDetail } from "./ISubscriptionDetail";
import { Userdetail } from "./IuserDTO";
import { Http } from "@angular/http";
import {Injectable} from '@angular/core';
import { IUserdetailDTO } from "../DTOs/IUserdetail_DTO";
import { ILoginDetailDTO } from "../DTOs/Ilogindetail_DTO";
import { ISubscriptionDetailDTO } from "../DTOs/ISubscriptiondetail_DTO";
import { IAddressDTO } from "../DTOs/IAddress_DTO";


@Injectable()
export class TenantApiService {
    user: IUser;
    basic_detail: IBasicDetail;
    login_detail: ILoginDetail;
    subscription_detail: ISubscriptionDetail;
 
    user_detailsDTO:IUserdetailDTO;
    login_detailsDTO:ILoginDetailDTO;
    subscription_detailDTO:ISubscriptionDetailDTO;
    address_detailDTO:IAddressDTO;
    
    constructor( private _http:Http) {

    }



    bindBasicDetails(basicdetail: IBasicDetail) {
        this.basic_detail = basicdetail;
        console.log(this.basic_detail);
    }

    bindLoginDetails(logindetail:ILoginDetail){
        this.login_detail=logindetail;
        console.log(this.login_detail);
    }

    bindSubscriptionDetails(subscriptionDetail:ISubscriptionDetail){
        this.subscription_detail=subscriptionDetail;
        console.log(this.subscription_detail);
    }

    getUserById(id:string){

        return this._http.get("http://192.168.2.11/TenantApi/api/tenant/GetUser/id?id="+id).toPromise();

    }
   
    registerUser() {
       

        this.user_detailsDTO={
            ShortName:this.login_detail.shortname,
            Name:this.basic_detail.customerName,
            UserRole:"Customer",
            Currency:this.basic_detail.currency,
            WebUrl:this.basic_detail.website,
           "address":[{
               City:this.basic_detail.city,
               Country:this.basic_detail.country,
               State:this.basic_detail.state,
               Street:this.basic_detail.street,
               Zipcode:this.basic_detail.pincode
           }],

           "contact":[{
               FirstName:this.basic_detail.contactPersonFname,
               LastName:this.basic_detail.contactPersonLname,
               Email:this.basic_detail.email,
               PhoneNumber:this.basic_detail.contactPersonmobileNo
               
           }]
            
            
        };

        this.login_detailsDTO={
            username:this.login_detail.username,
            password:this.login_detail.password,
            captcha:this.login_detail.captcha

        
        };

        this.subscription_detailDTO={
            type:this.subscription_detail.type,
            noOfNamedUser:this.subscription_detail.noOfNamedUser,
            modules:this.subscription_detail.modules,
            services:this.subscription_detail.services
        };

        this.address_detailDTO={
            City:this.basic_detail.city,
            Country:this.basic_detail.country,
            State:this.basic_detail.state,
            Street:this.basic_detail.street,
            Zipcode:this.basic_detail.pincode


        }

        return this._http.post("http://192.168.2.11/TenantApi/api/tenant/AddUser",{
            "basicdetail":this.user_detailsDTO,
            "logindetail":this.login_detailsDTO,
            "subscriptiondetail":this.subscription_detailDTO,
            
        }).toPromise();


    }


}