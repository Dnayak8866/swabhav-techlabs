"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Student = /** @class */ (function () {
    function Student(_firstname, _lastname) {
        this._firstname = _firstname;
        this._lastname = _lastname;
    }
    Object.defineProperty(Student.prototype, "Details", {
        get: function () {
            return "Student details  \n                    firstname:" + this._firstname + "\n                    Lastname:" + this._lastname;
        },
        enumerable: true,
        configurable: true
    });
    return Student;
}());
exports.Student = Student;
/* let s1 = new Student("Dharmesh","Nayak");
let s2 = new Student("Chandan","Maharana");

console.log( s1.Details);
console.log(s2.Details);  */ 
