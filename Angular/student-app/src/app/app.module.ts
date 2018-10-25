import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';
import { AppComponent } from './app.component';
import { from } from 'rxjs';
import { RouterModule } from '@angular/router';
import {RouteArray} from './RouteConfig';
import { HomeComponent } from './home.component';

import {StudentService} from './services/studentservice';
import { HttpModule} from '@angular/http';
import { AddStudentComponent } from './addstudent.component';
import{EditStudentComponent} from './editstudent.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AddStudentComponent,
    EditStudentComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(RouteArray),
    HttpModule

  ],
  providers: [StudentService],
  bootstrap: [AppComponent]
})
export class AppModule { }
