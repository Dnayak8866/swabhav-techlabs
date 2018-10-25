import { Component } from "@angular/core";

@Component({templateUrl:"./parentchild.component.html",selector:"st-parentchild"})
export class ParentChildComponent{

    msgFromChild:string;
    ratingFromChild:string;
    statechangeHandler(e:string){
        console.log(e);
        this.msgFromChild=e;
    }

    currentRating(e:number){
        console.log("Rating from child :"+e);
        this.ratingFromChild="Rating from Child StarComponent : "+e;
    }
}