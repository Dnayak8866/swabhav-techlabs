import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import {FormsModule} from '@angular/forms';
import { HomeComponent } from './home.component';
import { AddContactComponent } from './addcontact.component';

import { RouterModule } from '@angular/router';
import {RouteArray} from './RouteConfig';
import { ContactService } from './services/contactservice';

import { EditContactComponent } from './editcontact.component';
import { DeleteComponenet } from './delete.component';
import { LoginService } from './services/LoginService';
import { LoginComponent } from './login.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AddContactComponent,
    EditContactComponent,
    DeleteComponenet,
    LoginComponent,
   
   

  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(RouteArray)
  ],
  providers: [ContactService,LoginService],
  bootstrap: [AppComponent]
})
export class AppModule { }
