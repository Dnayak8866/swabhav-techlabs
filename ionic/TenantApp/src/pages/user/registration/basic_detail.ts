import { Component } from "@angular/core";


import { LoginPage } from "../login/login";
import { Tabs, NavController, Tab } from "ionic-angular";
import { TenantApiService } from "../../../services/TenantApiService";
import { IBasicDetail } from "../../../services/IBasicDetail";
import { IUserdetailDTO } from "../../../DTOs/IUserdetail_DTO";
import { IAddressDTO } from "../../../DTOs/IAddress_DTO";


@Component({ templateUrl: "./basic_detail.html" })
export class BasicDetailPage {

    basicdetail: IBasicDetail;

    customerName: string;
    country: string;
    state: string;
    street: string;
    city: string;
    pincode: number;
    weburl: string;
    currency: string;

    contactPersonFname: string;
    contactPersonLname: string;
    contactPersonMobile: number;
    contactPersonEmail: string;

    constructor(private _navCtrl: NavController, private _tenantService: TenantApiService) {
        if (localStorage.getItem("loginid") != null) {
            var id = localStorage.getItem("loginid");
            this.getBasicDetails(id);
        }

    }

    goToLoginDetail() {



        this.bindBasicDetail();
        var t: Tabs = this._navCtrl.parent;


        var loginTab: Tab = t.getByIndex(1);
        loginTab.enabled = true;

        t.select(1);
    }

    bindBasicDetail() {
        this.basicdetail = {
            customerName: this.customerName,
            country: this.country,
            state: this.state,
            city: this.city,
            street: this.street,
            website: this.weburl,
            pincode: this.pincode,
            currency: this.currency,
            contactPersonmobileNo: this.contactPersonMobile,
            contactPersonFname: this.contactPersonLname,
            contactPersonLname: this.contactPersonLname,
            email: this.contactPersonEmail


        }

        this._tenantService.bindBasicDetails(this.basicdetail);
    }

    getBasicDetails(id: string) {
        this._tenantService.getUserById(id)
            .then((r) => {
                var user: IUserdetailDTO = r.json();

                this.customerName = user.Name;
                this.weburl = user.WebUrl;
                this.currency = user.Currency;
                this.city=user.address[0].City;
                this.state=user.address[0].State;
                this.pincode=user.address[0].Zipcode;
                this.country=user.address[0].Country;
                this.street=user.address[0].Street;
              
                console.log("Pincode",this.pincode);
                
                this.contactPersonEmail=user.contact[0].Email;
                this.contactPersonFname=user.contact[0].FirstName;
                this.contactPersonLname=user.contact[0].LastName;
                this.contactPersonMobile=user.contact[0].PhoneNumber;




            })
            .catch((e) => console.log("Error getting user..", e));
    }

  

}