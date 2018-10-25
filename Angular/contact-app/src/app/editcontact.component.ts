import { Component } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { ContactService } from "./services/contactservice";
import { resolve } from "q";

@Component({ templateUrl: "./editcontact.component.html" })
export class EditContactComponent {

    name: string;
    num:number;
    constructor(private _routes: ActivatedRoute,private _contactService:ContactService,private _router:Router) {
       
        this._routes.params.subscribe(params =>this._contactService.getContactIndex(params.name));
      
    }

    savechanges(){
        
      this._contactService.updateContact(this.name,this.num)
      .then((resolve)=>this._router.navigate(['Home']))
      .catch((reject)=>console.log("Update operation failed......"));
      
    }
}