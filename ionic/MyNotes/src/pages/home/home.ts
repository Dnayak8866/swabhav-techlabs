import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { INote } from '../../services/INote';
import { NotesTrackerService } from '../../services/NotesTrackerService';
import { AddPage } from '../addNote/add';


@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  isToReorder=false;
  isHidePlayIcon=false;
  constructor(public navCtrl: NavController, private _noteTrackerService: NotesTrackerService) {
    

    //  let note1:INote = {
    //   title: "title1",
    //   description: "asfafaf"
    // }

    // let note2:INote = {
    //   title: "title2",
    //   description: "asfafaf"
    // }

    // this._noteTrackerService.addNewNote(note1);
    // this._noteTrackerService.addNewNote(note2);
  }

  getAllNotes(){
    return this._noteTrackerService.getAllNotes();
  }

  btnReorderClicked(){
    if(this.isToReorder){
        this.isToReorder=false;
        setTimeout(()=>{this.isHidePlayIcon=false;},500);
        
        return;
    }
    this.isToReorder=true;
    this.isHidePlayIcon=true;
  }

  btnNewNoteClicked(){
    console.log("add method...");
    this.navCtrl.push(AddPage);
  }

  reorderItems(indexes){
    console.log("inside reorder",indexes);
    this._noteTrackerService.reorderNotesArray(indexes);

  }

  deleteBtnClicked(note:INote){
    console.log(note.title);
    this._noteTrackerService.deleteNote(note);
  }

  slidingItemClicked(note:INote){
    this.navCtrl.push(AddPage,{singleNote:note});
   

  }

}
