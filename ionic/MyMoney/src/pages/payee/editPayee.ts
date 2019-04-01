import { Component } from "@angular/core";
import { PayeeService } from "../../services/PayeeService";
import { NavController, NavParams } from "ionic-angular";
import { IPayee } from "../../services/IPayee";
import { AlertController } from 'ionic-angular';
import { HomePage } from "../home/home";

@Component({ selector: 'page-EditPayee', templateUrl: './editPayee.html' })
export class EditPayee {

    payee: IPayee;
    isDisableTrash = true;
    paidamount: number;
    selectedDate: string;
    amountRecieved: number;
    creditOrDebit: string;

    totalAmount: number;
    constructor(private alertCtrl:AlertController ,private payeeService: PayeeService, private navctrl: NavController, private _navparams: NavParams) {
        //   this.payee=Object.assign({}, this._navparams.get('payeeobj'));

        this.payee = this._navparams.get('payeeobj');
        this.totalAmount = this.payee.amount;
        this.creditOrDebit = "";
        console.log(this.totalAmount);

        console.log(this.payee);

    }

    deletePayee() {
        console.log("delete payee..");
        this.confirmDeletePayee();
        

    }

    cancel() {
        console.log("cancel...");
    }

    btnDoneClick() {
        console.log(this.creditOrDebit);
        this.confirmTransaction(); 

    }


    confirmTransaction() {
        let alert = this.alertCtrl.create({
          title: 'Confirm Transaction',
          message: 'Are you sure...?',
          buttons: [
            {
              text: 'Cancel',
              role: 'cancel',
              handler: () => {
                console.log('Cancel clicked');
                return;
              }
            },
            {
              text: 'Done',
              handler: () => {
                console.log('Done clicked');
                console.log(this.creditOrDebit);
                if (this.creditOrDebit.toLowerCase() == "credit") {
                   console.log("inside credit...");
                    this.totalAmount = Number( this.totalAmount) + Number(this.amountRecieved);
                    console.log(this.totalAmount);
                    this.payee.amount = this.totalAmount;
                    this.payeeService.updatePayee(this.payee);
                    this.navctrl.pop();
                    return;
                    
                }
                if (this.amountRecieved >= 0 && this.totalAmount >= this.amountRecieved) {
                    console.log("inside...");
                    
                    this.totalAmount = (this.totalAmount - this.amountRecieved);
                    this.payee.amount = this.totalAmount;
                    this.payeeService.updatePayee(this.payee);
                    console.log(this.totalAmount);
                    this.navctrl.pop();
                }
            
                
              }
            }
          ]
        });
        alert.present();
       
      }

      confirmDeletePayee() {
        let alert = this.alertCtrl.create({
          title: 'Confirm Delete',
          message: 'Are you sure...?',
          buttons: [
            {
              text: 'No',
              role: 'cancel',
              handler: () => {
                
                return;
              }
            },
            {
              text: 'Yes',
              handler: () => {           
                this.payeeService.deletePayee(this.payee.id);
                this.navctrl.pop();   
              }
            }
          ]
        });
        alert.present();
       
      }


}