import { BrowserModule } from '@angular/platform-browser';
import { ErrorHandler, NgModule } from '@angular/core';
import { IonicApp, IonicErrorHandler, IonicModule } from 'ionic-angular';
import { SplashScreen } from '@ionic-native/splash-screen';
import { StatusBar } from '@ionic-native/status-bar';

import { MyApp } from './app.component';
import { HomePage } from '../pages/home/home';
import {ExpenseTrackerService} from "../services/ExpenseTrackerService";
import {ExpenseDetailPage} from "../pages/details/expenseDetails";
import {LoginPage} from "../pages/login/login";
import {AuthenticationService} from "../services/AuthenticationService";

@NgModule({
  declarations: [
    MyApp,
    HomePage,
    ExpenseDetailPage,
    LoginPage
  ],
  imports: [
    BrowserModule,
    IonicModule.forRoot(MyApp)
  ],
  bootstrap: [IonicApp],
  entryComponents: [
    MyApp,
    HomePage,
    ExpenseDetailPage,
    LoginPage
  ],
  providers: [
    StatusBar,
    SplashScreen,
    ExpenseTrackerService,
    AuthenticationService,
    {provide: ErrorHandler, useClass: IonicErrorHandler}
  ]
})
export class AppModule {}
