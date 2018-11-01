import { Component } from "@angular/core";
import { BasicDetailPage } from "../../user/registration/basic_detail";
import { LoginDetailPage } from "../../user/registration/login_detail";
import { SubscriptionDetailPage } from "../../user/registration/subscription_detail";

@Component({templateUrl:"./registration_tab.html"})
export class RegistrationTabsPage{

    tab1Root=BasicDetailPage;
    tab2Root=LoginDetailPage;
    tab3Root=SubscriptionDetailPage;

    constructor(){
       
    }
    

}