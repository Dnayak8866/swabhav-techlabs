var x:number=40;
//x="hello";

var CName:string="Swabhav";
var isValid:boolean=true;
var Company="Hitech"
var firstname="dharmesh";
console.log(CName);
console.log(isValid);


function cubeEvenNumber(val:number):number{
  
        if(val%2==0){
            return val*val*val;
        }
        throw new Error("Not an Even number....");

}
try{
    var result=cubeEvenNumber(2);
    console.log(result);
}catch(e){
   
    console.log(e);
}

let display= `Displaying values of variable
            Company name:${Company}
Firstname:${firstname}
`
console.log(display);


