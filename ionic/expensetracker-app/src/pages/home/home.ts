import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { IExpense } from '../../services/IExpense';
import { ExpenseTrackerService } from '../../services/ExpenseTrackerService';
import { ExpenseDetailPage } from '../details/expenseDetails';
import { LoginPage } from '../login/login';
import { AlertController } from 'ionic-angular';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  expenses: IExpense[];

  constructor(public navCtrl: NavController, private _expenseTracker: ExpenseTrackerService, private _alertCtrl: AlertController) {

    this.expenses = _expenseTracker.getAllExpenses();

  }

  cardClicked(expense: IExpense) {
    console.log(expense);
    this.navCtrl.push(ExpenseDetailPage, { expObj: expense });
  }

  fabClicked() {
    console.log("fab clicked...");
    this.navCtrl.push(ExpenseDetailPage);
  }

  logout() {

    let alert = this._alertCtrl.create({
      title: 'Logout',
      message: "Are you sure you want to logout",
      buttons: [
        {
          text: 'Cancel',
          role: 'cancel'

        },
        {
          text: 'Logout',
          handler: () => {

            console.log("Successfully logout...");
            localStorage.removeItem("loginstatus");
            this.navCtrl.setRoot(LoginPage);

          }
        }
      ]
    });

    alert.present();


   

  }


}
