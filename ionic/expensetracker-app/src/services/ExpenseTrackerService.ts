import { IExpense } from "./IExpense";

export class ExpenseTrackerService {

    expenses: IExpense[];

    constructor() {

        if (localStorage.getItem("Expenses") == null) {
            this.expenses = [];
            return;
        }
        this.expenses = JSON.parse(localStorage.getItem("Expenses"));
        // this.expenses=[
        //     {
        //         id:111,
        //         date:new Date("2011-10-22").toISOString(),
        //         category:"food",
        //         description:"Lunch"
        //     },

        //     {
        //         id:222,
        //         date:new Date("2018-06-02").toISOString(),
        //         category:"Trip",
        //         description:"Family Trip..."
        //     },

        //     {
        //         id:333,
        //         date:new Date("2018-07-22").toISOString(),
        //         category:"Food",
        //         description:"Party with friends.."
        //     },


        // ];

        // localStorage["Expenses"]=JSON.stringify(this.expenses);
    }

    getAllExpenses(): IExpense[] {

        return this.expenses;
    }

    updateExpenseDetail(expense: IExpense) {
        for (let i = 0; i < this.expenses.length; i++) {
            if (expense.id == this.expenses[i].id) {
                this.expenses[i] = expense;
                this.updateLocalStorage();
                return;
            }
        }
    }

    addExpenseDetail(expense: IExpense) {
        console.log("Inside service add method",expense);
        this.expenses.push(expense);
        this.updateLocalStorage();
    }

    deleteExpense(expense: IExpense) {  
        for (let index = 0; index < this.expenses.length; index++) {
            if (expense.id == this.expenses[index].id) {
                this.expenses.splice(index, 1);
                this.updateLocalStorage();
                return;
            }
        }
    }
    
    updateLocalStorage() {
        localStorage["Expenses"] = JSON.stringify(this.expenses);
    }
}