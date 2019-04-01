import { BrowserModule } from '@angular/platform-browser';
import { ErrorHandler, NgModule } from '@angular/core';
import { IonicApp, IonicErrorHandler, IonicModule } from 'ionic-angular';
import { SplashScreen } from '@ionic-native/splash-screen';
import { StatusBar } from '@ionic-native/status-bar';

import { MyApp } from './app.component';
import { HomePage } from '../pages/home/home';
import { AddPayee } from '../pages/payee/addPayee';
import { DatePicker, DatePickerOptions } from '@ionic-native/date-picker';
import { PayeeService } from '../services/PayeeService';
import { EditPayee } from '../pages/payee/editPayee';

@NgModule({
  declarations: [
    MyApp,
    HomePage,
    AddPayee,
    EditPayee
  ],
  imports: [
    BrowserModule,
    IonicModule.forRoot(MyApp)
  ],
  bootstrap: [IonicApp],
  entryComponents: [
    MyApp,
    HomePage,
    AddPayee,
    EditPayee
  ],
  providers: [
    StatusBar,
    SplashScreen,
    PayeeService,
    {provide: ErrorHandler, useClass: IonicErrorHandler},
    DatePicker
  ]
})
export class AppModule {}
