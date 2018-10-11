interface Icustomer{
    fname:string,
    lname:string,
    salary:number
}

function printSalarySlip(cutomers:Icustomer[]):void{
    for(let c of cutomers){
        console.log(c);
    }
}

printSalarySlip([{fname:"dharmesh",lname:"nayak",salary:18000},
                    {fname:"chandan",lname:"mahaarana",salary:18000}]);