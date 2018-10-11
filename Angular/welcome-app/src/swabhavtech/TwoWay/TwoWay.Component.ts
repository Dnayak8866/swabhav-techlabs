import { Component } from "@angular/core";
import { MathServices } from "../services/MathService";

@Component({templateUrl:`TwoWay.Component.html`, selector:"st-twoway"})
export class TwoWayComponent{

    firstname:string;
    lastname:string;
    num:number
    mathservice:MathServices;
    isPrime:boolean;
    result:any;

    constructor(private _mathService:MathServices){
        this.firstname="Dharmesh";
       this.mathservice=_mathService;
       this.result = "No result";
    }

    firstnameChange(e){
        console.log(e);
        this.firstname=e;
    }

    checkPrimeOrNot(val:number){
        this.isPrime=this.mathservice.isPrime(val);
        if(this.isPrime){
           return this.result="Number is prime";
        }
        this.result="Number is not Prime"
    }

    checkPrimeAsync(val:number){
   
       this.mathservice.isPrimeAsync(this.num)
       .then((d)=>{console.log(d); this.result="Number is prime"})
       .catch((e)=>{console.log(e); this.result="Number is not prime"});

        
     
    }
}