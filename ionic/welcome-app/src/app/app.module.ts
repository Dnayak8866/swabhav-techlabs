import { BrowserModule } from '@angular/platform-browser';
import { ErrorHandler, NgModule } from '@angular/core';
import { IonicApp, IonicErrorHandler, IonicModule } from 'ionic-angular';
import { SplashScreen } from '@ionic-native/splash-screen';
import { StatusBar } from '@ionic-native/status-bar';

import { MyApp } from './app.component';
import { HomePage } from '../pages/home/home';
import {NameMatcherPage} from '../pages/nameMatcher/nameMatcher';
import { Contacts } from '@ionic-native/contacts';
import { AboutPage } from '../pages/about/about';
import { CareerPage } from '../pages/career/career';


@NgModule({
  declarations: [
    MyApp,
    HomePage,
    NameMatcherPage,
    AboutPage,
    CareerPage
  ],
  imports: [
    BrowserModule,
    IonicModule.forRoot(MyApp)
  ],
  bootstrap: [IonicApp],
  entryComponents: [
    MyApp,
    NameMatcherPage,
    HomePage,
    AboutPage,
    CareerPage
  ],
  providers: [
    StatusBar,
    SplashScreen,
    Contacts,
    {provide: ErrorHandler, useClass: IonicErrorHandler}
  ]
})
export class AppModule {}
