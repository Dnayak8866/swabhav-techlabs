import { BrowserModule } from '@angular/platform-browser';
import { ErrorHandler, NgModule } from '@angular/core';
import { IonicApp, IonicErrorHandler, IonicModule } from 'ionic-angular';
import { SplashScreen } from '@ionic-native/splash-screen';
import { StatusBar } from '@ionic-native/status-bar';

import { MyApp } from './app.component';
import { HomePage } from '../pages/home/home';
import { MenuPage } from '../pages/menupage/menu';
import { UserAnnouncementPage } from '../pages/user/announcement/announcement';




import { ModulesPage } from '../pages/master/modulepage/modules';
import { PartnersPage } from '../pages/master/partnerpage/partner';
import { ServicesPage } from '../pages/master/servicepage/services';
import { BasicDetailPage } from '../pages/user/registration/basic_detail';
import { LoginDetailPage } from '../pages/user/registration/login_detail';
import { SubscriptionDetailPage } from '../pages/user/registration/subscription_detail';
import { RegistrationTabsPage } from '../pages/tabs/userTabs/registration_tab';
import { UserProfilePage } from '../pages/user/userprofile/user_profile';
import { WelcomeKitPage } from '../pages/user/welcomekit/welcomekit';
import { LoginPage } from '../pages/user/login/login';
import {  TenantApiService } from '../services/TenantApiService';
import { HttpModule } from '@angular/http';
import { LoginService } from '../services/LoginService';

@NgModule({
  declarations: [
    MyApp,
    HomePage,
    MenuPage,
    UserAnnouncementPage,
    UserProfilePage,
    RegistrationTabsPage,
    ModulesPage,
    PartnersPage,
    ServicesPage,
    BasicDetailPage,
    LoginDetailPage,
    SubscriptionDetailPage,
    WelcomeKitPage,
    LoginPage
  ],
  imports: [
    BrowserModule,
    HttpModule,
    IonicModule.forRoot(MyApp)
  ],
  bootstrap: [IonicApp],
  entryComponents: [
    MyApp,
    HomePage,
    MenuPage,
    UserAnnouncementPage,
    UserProfilePage,
    RegistrationTabsPage,
    ModulesPage,
    PartnersPage,
    ServicesPage,
    BasicDetailPage,
    LoginDetailPage,
    SubscriptionDetailPage,
    WelcomeKitPage,
    LoginPage
  ],
  providers: [
    StatusBar,
    SplashScreen,
    TenantApiService,
    LoginService,
    {provide: ErrorHandler, useClass: IonicErrorHandler}
  ]
})
export class AppModule {}
