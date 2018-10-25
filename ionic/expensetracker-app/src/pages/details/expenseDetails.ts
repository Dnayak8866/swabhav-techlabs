import { Component } from "@angular/core";
import { NavParams, NavController } from "ionic-angular";
import { IExpense } from "../../services/IExpense";
import { ExpenseTrackerService } from "../../services/ExpenseTrackerService";
import { HomePage } from "../home/home";
import { AlertController } from 'ionic-angular';

@Component({ templateUrl: "./expenseDetails.html" })
export class ExpenseDetailPage {

    expense: IExpense;
    isInputIdDisable: boolean;

    isDisableTrash: boolean;
    navHeading: string;
    constructor(private _navCtrl: NavController, private _navparams: NavParams, private _expenseService: ExpenseTrackerService, private _alertCtrl: AlertController) {

        this.isInputIdDisable = true;
        this.isDisableTrash = false;
        this.navHeading = "Expense Edit";

        this.expense = Object.assign({}, this._navparams.get('expObj'));
        if (this._navparams.get('expObj') == null) {
            console.log("expense is  null");
            this.isInputIdDisable = false;
            this.isDisableTrash = true;
            this.navHeading = "Expense Add";


        }

    }
    cancel() {
        console.log("cancel clicked....");
        this._navCtrl.pop();
    }

    save() {

        console.log("save clicked....");
        if (this._navparams.get('expObj') == null) {

            this._expenseService.addExpenseDetail(this.expense);
            this._navCtrl.pop();
            return;
        }
        this._expenseService.updateExpenseDetail(this.expense);
        this._navCtrl.pop();
    }

    deleteExpense() {

        let alert = this._alertCtrl.create({
            title: 'Delete',
            message: "Are you sure you want to delete this detail",
            buttons: [
                {
                    text: 'Cancel',
                    role: 'cancel',
                    handler: () => { console.log("deleted...") }
                },
                {
                    text: 'Delete',
                    handler: () => {
                       
                        this._expenseService.deleteExpense(this.expense);
                        this._navCtrl.pop();

                    }
                }
            ]
        });

        alert.present();

        

    }



}