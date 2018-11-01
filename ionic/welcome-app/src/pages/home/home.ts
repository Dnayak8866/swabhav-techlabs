import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { AboutPage } from '../about/about';
import { CareerPage } from '../career/career';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  msg="Welcome to ionic App";
  constructor(public navCtrl: NavController) {

  }


}
