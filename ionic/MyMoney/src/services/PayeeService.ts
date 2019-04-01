import { IPayee } from "./IPayee";


export class PayeeService{
    payees:IPayee[];
    searchedPayees:IPayee[];

    constructor(){
        if(localStorage.getItem("payees")==null){
            this.payees=[];
            return;
        }
        this.payees=JSON.parse(localStorage.getItem("payees"));
    }

    getAllPayees():IPayee[]{
        return this.payees;
    }

    searchPayeeByName(name):IPayee[]{
        console.log("search method",name);
        this.searchedPayees=[];
        for(let index=0;index <this.payees.length;index++){
            if(this.payees[index].name.toLowerCase().includes(name.toLowerCase())){
                console.log(this.payees[index]);
                 this.searchedPayees.push(this.payees[index]);
            }
        }
        return this.searchedPayees;
    }
    addPayee(payee:IPayee){
        this.payees.push(payee);
        console.log(this.payees);
        this.updateLocalStorage();

    }

    updateLocalStorage() {
        localStorage["payees"] = JSON.stringify(this.payees);
    }

    deletePayee(payeeID){
        console.log("Payee id",payeeID);
        for(let index=0;index <this.payees.length;index++){
            if(this.payees[index].id == payeeID){
                console.log(this.payees[index]);
                 this.payees.splice(index,1);
                 this.updateLocalStorage();
                 return;
            }
        }
    }

    updatePayee(payee){
        for(let index=0;index <this.payees.length;index++){
            if(this.payees[index].id==payee.id){
                this.payees[index]=payee;
            }
        }
        this.updateLocalStorage();
    }
}