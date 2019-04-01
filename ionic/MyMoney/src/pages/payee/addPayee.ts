import { Component } from "@angular/core";
import { DatePicker, DatePickerOptions } from '@ionic-native/date-picker';
import { IPayee } from "../../services/IPayee";
import { PayeeService } from "../../services/PayeeService";
import { NavController } from "ionic-angular";


@Component({ templateUrl: './addPayee.html' })
export class AddPayee {

    selectedDate: string;
    name:string;
    amount:number;

    payee:IPayee;

    constructor(private datepicker: DatePicker,private payeeService:PayeeService,private navctrl:NavController) {
        console.log("Add payee...");
        
       
    }

    SelectDate() {
        console.log("Select date..");
        this.datepicker.show({
            date: new Date(),
            mode: 'date',
            androidTheme: this.datepicker.ANDROID_THEMES.THEME_DEVICE_DEFAULT_LIGHT
        }).then(
            date => {this.selectedDate=date.toDateString()},
            err => console.log('Error occurred while getting date: ', err)
        );
    }

    SavePayee(){
       // this.payee.date=this.selectedDate;
       var id= Date.now() + Math.random();
       console.log("Unique ID:",id);
       this.payee={
           id:id,
           name:this.name,
           amount:this.amount,
           date:this.selectedDate,
           paidDate:null
       }
        console.log(this.payee);
        this.payeeService.addPayee(this.payee);
        this.navctrl.pop();
    }

}