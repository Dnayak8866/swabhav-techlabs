import { INote } from "./INote";
import {reorderArray} from "ionic-angular";

export class NotesTrackerService{

    myNotes:INote[];

    constructor(){

        if(localStorage.getItem("mynotes")==null){
            this.myNotes=[];
            return;
        }
        this.myNotes = JSON.parse(localStorage.getItem("mynotes")) ;


    }

    getAllNotes(){
        return this.myNotes;
    }

    addNewNote(note:INote){
        this.myNotes.push(note);
        this.updateLocalStorage();
    }

    deleteNote(note:INote){
        for(let i=0;i<this.myNotes.length;i++){
            if(this.myNotes[i].title==note.title){
                this.myNotes.splice(i,1);
                this.updateLocalStorage();
                return;
            }
        }
    }
    updateLocalStorage(){
        localStorage["mynotes"] = JSON.stringify(this.myNotes);
    }

    reorderNotesArray(indexes){
        this.myNotes=reorderArray(this.myNotes,indexes);
        this.updateLocalStorage();
    }

    getIndexOfNote(note:INote):number{
       
        for(let index=0;index<this.myNotes.length;index++){
            if(this.myNotes[index].title == note.title){
               console.log("matched...");
               return index;
            }
        }
    }

    editNote(index:number,note:INote){
        this.myNotes[index]=note;
        this.updateLocalStorage();
    }


}