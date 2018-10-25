import { Component } from "@angular/core";
import { ActivatedRoute } from "@angular/router";

@Component({template:`<h1>Service Component</h1>
                      <h2>{{data}}</h2>`})
export class ServiceComponent{
    data:string;

    constructor(private _route:ActivatedRoute){
        this._route.params.subscribe(params=>this.data=params.id);
        console.log(this.data);
    }

}