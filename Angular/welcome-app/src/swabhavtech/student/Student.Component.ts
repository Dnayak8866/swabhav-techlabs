import { IStudent } from "./IStudent";
import { Component } from "@angular/core";

@Component({templateUrl:`Student.Component.html`,selector:'st-student'})
export class studentcomponent{
    imageWidth=300;
    imageHeight=150;
    student:IStudent;
    students:IStudent[];
    constructor(){
        this.student={
            name:"Dharmesh",
            location:"Surat",
            
            cgpa:8.98,
            photo:'assets/pictures/pic.jpg'
        }
        

    }

    calculatecolor(cgpa:number):string{
        if(cgpa>6){
            return "green";
        }
        return "red";
    }

    loadStudents():void{
        this.students=[
            {name:"Dharmesh",location:"surat",cgpa:8.8,photo:'assets/pictures/pic.jpg'},
            {name:"Chandan",location:"Surat",cgpa:8.9,photo:'assets/pictures/pic.jpg'},
            {name:"Abhishek",location:"Surat",cgpa:9,photo:'assets/pictures/pic.jpg'},
            {name:"Prashant",location:"Navsari",cgpa:5,photo:'assets/pictures/pic.jpg'}

        ];
    }

    


}