import { Component } from '@angular/core';

@Component({templateUrl:`welcome.component.html`,selector:'st-welcome'})
export class welcomecomponent{
     msg: string;
     public wish:string;
     public name:string;
     constructor(){
        this.msg='Hello World';
    }
}