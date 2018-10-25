import { Component } from "@angular/core";
import { ContactService } from "./services/contactservice";
import { Icontact } from "./services/Icontact";
import { ActivatedRoute } from "@angular/router";

@Component({templateUrl:"./home.component.html"})
export class HomeComponent{

    contacts:Icontact[];
    contact:Icontact;
    name:string;
    num:number;
    constructor(private _contactService:ContactService){

     this.contacts=_contactService.getAllContacts();
    }

    
}