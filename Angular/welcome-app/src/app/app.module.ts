import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import{FormsModule} from '@angular/forms';
import { welcomecomponent } from '../swabhavtech/welcome.component';
import {studentcomponent} from '../swabhavtech/student/Student.Component';
import {BlueBoxComponent} from '../swabhavtech/Bluebox/Bluebox.Component';
import { format } from 'util';
import { TwoWayComponent } from '../swabhavtech/TwoWay/TwoWay.Component';
import {MathServices} from '../swabhavtech/services/MathService';
import { NumbersComponent } from '../swabhavtech/numberApi/Number.Component';
import { HttpModule} from '@angular/http';
import {NumberServices} from '../swabhavtech/services/NumberService';

@NgModule({
  declarations: [
   welcomecomponent,
   studentcomponent,
   BlueBoxComponent,
   TwoWayComponent,
   NumbersComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule
    
  ],
  providers: [MathServices,NumberServices],
  bootstrap: [welcomecomponent]
})
export class AppModule { }
