import { Component } from "@angular/core";

@Component({templateUrl:"./calculatePercentage.html"})
export class CalculatePercentagePage{

    inputValueFirst:number;
    inputOfValueSecond:number;
    result1:number;
 

    inputBox3:number;
    inputBox4:number;
    result2:number;
  

    inputBox5:number;
    inputBox6:number;
    result3:number;
  
    txt:string;
   


    constructor(){
       
        this.result1=0;
        this.result2=0;
        this.result3=0;
        
        this.txt=`What is the percentage increase/decrease
                  from`;
    }
    
   
    calculateResultFirst(){
       
        if(isNaN(this.inputValueFirst) || isNaN(this.inputOfValueSecond) || this.inputValueFirst==0 || this.inputOfValueSecond==0){
           this.result1=0;
            return;
        }
       
        this.result1=(this.inputValueFirst*this.inputOfValueSecond)/100;
      
    }

    calculateResultSecond(){
        console.log("value of second box ",this.inputBox4);
      if(isNaN(this.inputBox3) || isNaN(this.inputBox4 ) || this.inputBox4==0 || this.inputBox3==0){
          console.log("NAN called....");
         this.result2=0;
        return;
      }

      this.result2=(100*this.inputBox3)/this.inputBox4;
      
    }

    calculateResultThird(){
        if(isNaN(this.inputBox5) || isNaN(this.inputBox6) || this.inputBox5==0 || this.inputBox6==0){
            console.log("zero....");
            this.result3=0;
            return;
        }
        let differnce = this.inputBox6 - this.inputBox5;
        this.result3 = (differnce/this.inputBox5*100);
       
    }





   

}