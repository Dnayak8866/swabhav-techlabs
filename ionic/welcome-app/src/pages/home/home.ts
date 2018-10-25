import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  msg="Welcome to ionic App";
  constructor(public navCtrl: NavController) {

  }

}
