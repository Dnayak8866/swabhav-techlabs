import { resolve } from "url";
import { Http } from "@angular/http";
import {Injectable} from '@angular/core';

@Injectable()
export class StudentService{




    constructor(private _http:Http){

    }
    getAllStudents(){
       return this._http.get("http://gsmktg.azurewebsites.net:80/api/v1/techlabs/test/students/").toPromise();
    }

    addStudent(student:any){
        return this._http.post("http://gsmktg.azurewebsites.net:80/api/v1/techlabs/test/students", student).toPromise();
    }
    
    updateStudentDetail(student:any){
        console.log("called...");
        return this._http.put("http://gsmktg.azurewebsites.net:80/api/v1/techlabs/test/students/" + student.rollNo, student).toPromise();
    }

    deleteStudentRecord(rollNo:string){
        if (confirm("Are you sure you want to delete this data..!")) {
            return this._http.delete("http://gsmktg.azurewebsites.net:80/api/v1/techlabs/test/students/" + rollNo).toPromise();
        } 
    }
}