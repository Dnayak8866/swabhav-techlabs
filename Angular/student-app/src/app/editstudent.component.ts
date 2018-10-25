import { Component } from "@angular/core";
import { StudentService } from "./services/studentservice";
import { ActivatedRoute, Router } from "@angular/router";

@Component({templateUrl:"./editstudent.component.html"})
export class EditStudentComponent{

    student:any;
    rollNo:string;
    name:string;
    age:string;
    email:string;
    date:string;

    constructor(private _studentService:StudentService,private _routes:ActivatedRoute,private _router:Router){
        this.student={};
        this._routes.params.subscribe(params=>{
            this.rollNo=params.rollno;
            this.name=params.name;
            this.age=params.age;
            this.email=params.email;
            this.date=params.date;
        });
        console.log("Inside edit cons..",this.rollNo);
    }

    updateStudent(){
        console.log("inside updatemethod...");
        this.student={
            rollNo: this.rollNo,
            name: this.name,
            age: this.age,
            email: this.email,
            date: this.date
        };


        this._studentService.updateStudentDetail(this.student)
        .then((r)=>{
            console.log("Successfully updated...");
            this._router.navigate(['Home']);
        })
        .catch((e)=>console.log("Update operation failed.."));
    }

}