var x = 40;
//x="hello";
var CName = "Swabhav";
var isValid = true;
var Company = "Hitech";
var firstname = "dharmesh";
console.log(CName);
console.log(isValid);
function cubeEvenNumber(val) {
    if (val % 2 == 0) {
        return val * val * val;
    }
    throw new Error("Not an Even number....");
}
try {
    var result = cubeEvenNumber(2);
    console.log(result);
}
catch (e) {
    console.log(e);
}
var display = "Displaying values of variable\nCompany name:" + Company + "\nFirstname:" + firstname + "\n";
console.log(display);
