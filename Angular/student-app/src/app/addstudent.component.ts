import { Component } from "@angular/core";
import { StudentService } from "./services/studentservice";
import { Router } from "@angular/router";

@Component({templateUrl:"./addstudent.component.html"})
export class AddStudentComponent{

    rollNo:string;
    name:string;
    age:string;
    email:string;
    date:string;
    student:any={};
    constructor(private _studentService:StudentService,private _router:Router){

    }

    addNewStudent(){
        this.student={
            rollNo: this.rollNo,
            name: this.name,
            age: this.age,
            email: this.email,
            date: this.date
        };
        if(this.rollNo!=null && this.name!=null && this.age!=null && this.email!=null && this.date!=null){
            this._studentService.addStudent(this.student)
            .then((r)=>{
                console.log("Successfully added...");
                this._router.navigate(['Home']);
            })
            .catch((e)=>console.log("Student add operation failed..."));
        }
       
        
    }
}