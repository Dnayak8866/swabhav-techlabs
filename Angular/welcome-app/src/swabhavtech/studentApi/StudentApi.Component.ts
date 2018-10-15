import { IStudent } from "./IStudent";
import { Component } from "@angular/core";

@Component({templateUrl:`StudentApi.Component.html`,selector:'st-studentApi'})
export class studentApiComponent{
  
    student:IStudent;
    students:IStudent[];
    name:string;
    location:string;
    radioVal:string;
    description:string;
    isHideForm=true;
    isHideStudentTable=true;
    constructor(){
        this.student={
            name:"Dharmesh",
            location:"Surat",
            gender:"Female",
            description:`Lorem Ipsum is simply dummy text of the printing and typesetting industry.
             Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 
             when an unknown printer took a galley of type and scrambled it to make a type specimen book. 
             It has survived not only five centuries, but also the leap into electronic typesetting,
            remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
            and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.`;
      
        }

        this.students=[
            {name:"Dharmesh",location:"surat",gender:"male", description:`Lorem Ipsum is simply dummy text of the printing and typesetting industry.
            Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 
            when an unknown printer took a galley of type and scrambled it to make a type specimen book. 
            It has survived not only five centuries, but also the leap into electronic typesetting,
           remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
           and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.`;
     },
            {name:"foo",location:"andheri",gender:"female", description:`Lorem Ipsum is simply dummy text of the printing and typesetting industry.
            Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 
            when an unknown printer took a galley of type and scrambled it to make a type specimen book. 
            It has survived not only five centuries, but also the leap into electronic typesetting,
           remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
           and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.`;
     },
            {name:"Chandan",location:"surat",gender:"male", description:`Lorem Ipsum is simply dummy text of the printing and typesetting industry.
            Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 
            when an unknown printer took a galley of type and scrambled it to make a type specimen book. 
            It has survived not only five centuries, but also the leap into electronic typesetting,
           remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
           and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.`;
     }
        ];
        

    }

    addStudent(){
        if(this.isHideForm){
          return  this.isHideForm=false;
        }
        this.isHideStudentTable=true;
        this.students.push({name:this.name,location:this.location,gender:this.radioVal, description:this.description});
       
    }

    displayStudents(){
       this. isHideStudentTable=false;
    }
    

    // displayStudents():void{
    //     this.students=[
    //         {name:"Dharmesh",location:"surat",c,photo:'assets/pictures/pic.jpg'},
    //         {name:"Chandan",location:"Surat",cgpa:8.9,photo:'assets/pictures/pic.jpg'},
    //         {name:"Abhishek",location:"Surat",cgpa:9,photo:'assets/pictures/pic.jpg'},
    //         {name:"Prashant",location:"Navsari",cgpa:5,photo:'assets/pictures/pic.jpg'}

    //     ];
    // }

    


}