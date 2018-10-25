
import { Component, Output, EventEmitter, OnInit } from "@angular/core";
import { Icontact } from "./services/Icontact";
import { Router } from "@angular/router";
import { ContactService } from "./services/contactservice";
@Component({templateUrl:"./addcontact.component.html"})

export class AddContactComponent  {

    name:string;
    num:number;
   
    contact:Icontact;
    constructor(private _contactService:ContactService,private _router:Router){
        
    }

    addContact(){
        this._contactService.addContact(this.name,this.num)
        .then((resolve=>{this._router.navigate(['Home'])}))
        .catch((reject=>console.log("Contact not added...")));
        
    }
 
}