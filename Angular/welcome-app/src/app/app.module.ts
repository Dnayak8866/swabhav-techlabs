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
import{QuestionBankComponent} from '../swabhavtech/QuestionBank/QuestionBank.Component';
import {SummaryComponent}from'../swabhavtech/summarypipe/summary.component';
import {SummaryPipe} from '../swabhavtech/summarypipe/summarypipe';
import {studentApiComponent} from '../swabhavtech/studentApi/StudentApi.Component';
import {GenderToColorPipe} from '../swabhavtech/studentApi/GenderToColorPipe';
@NgModule({
  declarations: [
   welcomecomponent,
   studentcomponent,
   BlueBoxComponent,
   TwoWayComponent,
   NumbersComponent,
   QuestionBankComponent,
   SummaryComponent,
   SummaryPipe,
   studentApiComponent,
   GenderToColorPipe
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
