import { Component } from "@angular/core";
import { NavController, NavParams } from "ionic-angular";
import { NotesTrackerService } from "../../services/NotesTrackerService";
import { INote } from "../../services/INote";

@Component({templateUrl:"./add.html"})
export class AddPage{

    note:INote;
    navHeading="Add Note";
    noteIndex:number; 
    constructor(private _navCtrl:NavController,private _noteTrackerService:NotesTrackerService,private _navparams:NavParams){
        if(this._navparams.get("singleNote")!=null){
            this.note = Object.assign({},this._navparams.get("singleNote"));
            this.noteIndex = this._noteTrackerService.getIndexOfNote(this.note);
            this.navHeading="Edit Note";
            return;
        }
        this.note={
            title:"",
            description:""
        }
    }

    addNote(){
        if(this._navparams.get("singleNote")!=null){
            console.log("not null note");
            this.editNote();
            this._navCtrl.pop();
            return;
        }
        console.log(this.note);
        this._noteTrackerService.addNewNote(this.note);
        this._navCtrl.pop();

    }
    editNote(){
       
        
        this._noteTrackerService.editNote(this.noteIndex,this.note);
    }

}