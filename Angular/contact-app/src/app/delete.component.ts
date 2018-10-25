import { ContactService } from "./services/contactservice";
import { ActivatedRoute, Router } from "@angular/router";
import { Component } from "@angular/core";
import { LoginService } from "./services/LoginService";
import { resolve } from "url";

@Component({template:'<h1>Deleted..</h1>'})
export class DeleteComponenet{
    constructor(private _routes:ActivatedRoute, private _contactService:ContactService,private _loginService:LoginService,private _router:Router){
        this._routes.params.subscribe(params=> this._contactService.getContactIndex(params.name));
        if(this._loginService.loggedInUser==null){
            this._router.navigate(['login']);
            return;
        }
        this._contactService.deleteContact()
        .then((resolve)=>console.log("Contact Deleted...."))
        .catch((reject)=>console.log("Delete operation failed..."));
    }

}