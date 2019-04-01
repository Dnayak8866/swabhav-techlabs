import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { AddPayee } from '../payee/addPayee';
import { IPayee } from '../../services/IPayee';
import { PayeeService } from '../../services/PayeeService';
import { EditPayee } from '../payee/editPayee';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  payees:IPayee[];
  isHideBaseContent:false;

  constructor(public navCtrl: NavController,private payeeService:PayeeService) {
    if(localStorage.getItem("payees")==null){
      return;
    }
    this.payees= this.payeeService.getAllPayees();
    console.log("Payees in home",this.payees);
  }


  seacrhPayee(){
    console.log("search payee...");
  }

  onInput(event:any){
    if(event.data==null){
      console.log("cancelled...");
      this.payees=this.payeeService.getAllPayees();
      return;
    }
    this.payees=[];
    this.payees=this.payeeService.searchPayeeByName(event.data);
    console.log(event.data);
  }
  onCancel(event:any){
    this.payees=this.payeeService.getAllPayees();
    console.log(event);
  }

  fabbtn_Clicked(){
    console.log("fab clicked.. add payee");
    this.navCtrl.push(AddPayee);
  }

  cardClicked(payee:IPayee){
    this.navCtrl.push(EditPayee,{payeeobj:payee});
    console.log("card clicked....");
  }

  deletePayee(id){
    console.log("delete id..",id);
  }

  

}
