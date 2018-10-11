import { Component } from "@angular/core";
import {NumberServices} from "../services/NumberService";
@Component({templateUrl:"Numbers.Component.html",selector:"st-numberapi"})
export class NumbersComponent{

    data:string[];
    num:number;
    inputnum:number;
    constructor(private _numberService:NumberServices){
        this.data=[];
    }
    getFacts(val:number){
        this.inputnum=val;
        this._numberService.getData(val)
            .then((response)=>this.data.push(response.text().toString()));
        
    }
}