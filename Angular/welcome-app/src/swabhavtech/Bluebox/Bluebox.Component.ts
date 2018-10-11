import { Component } from "@angular/core";
import { Ibutton } from "./Ibutton";

@Component({templateUrl:`BlueBox.Component.html`,selector:'st-bluebox'})
export class BlueBoxComponent{

    containerWidth=500;
    btnwidth=50;
    btnheight=50;
    btnMargin=5;
   
    randomBallId:number
    buttons:Ibutton[];
    btnindex;
    btn:Ibutton
    numOfChance;
    isToPlay=true;
    txtNumOfTry;



    constructor(){

        this.randomBallId = Math.ceil(Math.random() * 26);
     
        console.log(this.randomBallId);

    }
   
   
    createButton(){
        this.buttons=new Array(50);
        this.txtNumOfTry="No of try left :";
        for(let i=0;i<this.buttons.length;i++){
            this.btn={
                id:i+1,
                btnColor:"grey",
                isToDisable:false
            }
            this.buttons[i]=this.btn;
            this.numOfChance=5;
        }
    }
    
    guess(id:number){
        if(!this.isToPlay){
            alert("Game over.....");
            return
        }
        this.btnindex= this.getButtonIndex(id);
        this.checkResult(this.btnindex);
        this.disableButton(this.btnindex);
      
    }

    checkResult(btnindex:number){
        if(this.buttons[btnindex]['id'] > this.randomBallId  ){
            this.numOfChance--;
            return this.buttons[this.btnindex]["btnColor"]="green";
             
        }else if(this.buttons[btnindex]['id']==this.randomBallId){
            alert("Congratulation you selected the correct box.....")
            this.isToPlay=false;
           return this.buttons[this.btnindex]["btnColor"]="Blue";
           
        }
        this.numOfChance--;
        return this.buttons[this.btnindex]["btnColor"]="red";
 
    }

    getButtonIndex(id:number):number{
        for(let i=0;i<this.buttons.length;i++){
            if(this.buttons[i]["id"]==id){
              return i;
            }
        }
    }

    disableButton(btnindex:number){
        this.buttons[btnindex]['isToDisable']=true;
    }



  

    

}