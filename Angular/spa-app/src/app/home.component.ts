import { Component } from "@angular/core";
import { Router } from "@angular/router";

@Component({template:`<h1>Home Component</h1>
                   <input (click)="redirectToAbout()" type="button" value="navigateToAbout"> `})
export class HomeComponent{

    route:Router;
    constructor(route:Router){
       this.route=route;
    }
    redirectToAbout(){
        this.route.navigate(['About']);
    }
}