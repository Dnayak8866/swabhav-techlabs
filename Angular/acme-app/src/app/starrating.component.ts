import { Component, Input, OnInit, Output, EventEmitter } from "@angular/core";

@Component({templateUrl:"./starrating.component.html",selector:"st-starrating"})
export class StarRating implements OnInit{

    @Input()
    rating:number

    
 
    ngOnInit():void{
       
    }

  




}