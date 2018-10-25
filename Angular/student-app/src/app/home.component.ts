import { Component } from "@angular/core";
import { StudentService } from "./services/studentservice";

@Component({ templateUrl: "./home.component.html" })
export class HomeComponent {

    students: any[];
    constructor(private _studentService: StudentService) {
        this.students = [];
        this.getStudents();
    }
    deleteStudent(rollno: string) {

        this._studentService.deleteStudentRecord(rollno)
            .then((r) => {
                console.log("Successfully deleted....");
                this.getStudents();
            })
            .catch((e) => console.log("delete operation failed...."));
            
    }

    getStudents() {
        this._studentService.getAllStudents()
            .then((d) => { console.log(d.json()); this.students = d.json(); })
            .catch((e) => console.log(e));
        console.log(this.students);
    }
}