import { Component, ViewChild } from "@angular/core";
import { Nav, Platform } from 'ionic-angular';

import { HomePage } from '../home/home';
import { StatusBar } from "@ionic-native/status-bar";
import { SplashScreen } from "@ionic-native/splash-screen";
import { RegistrationTabsPage } from "../tabs/userTabs/registration_tab";
import { UserAnnouncementPage } from "../user/announcement/announcement";
import { WelcomeKitPage } from "../user/welcomekit/welcomekit";
import { ModulesPage } from "../master/modulepage/modules";
import { PartnersPage } from "../master/partnerpage/partner";
import { ServicesPage } from "../master/servicepage/services";
import { UserProfilePage } from "../user/userprofile/user_profile";


@Component({ templateUrl: "./menu.html" })
export class MenuPage {

    @ViewChild(Nav) nav: Nav;

    rootPage: any = HomePage;



    pages: Array<{ title: string, isHideSubmenu: boolean, iconname: string, subcomponents: Array<{ title: string, component: any }> }>;

    constructor(public platform: Platform, public statusBar: StatusBar, public splashScreen: SplashScreen) {


        // used for an example of ngFor and navigation
        this.pages = [
            {
                title: 'User', isHideSubmenu: true, iconname: "arrow-dropdown", subcomponents: [
                    {
                        title: "Register",
                        component: RegistrationTabsPage,
                    },
                    {
                        title: "Profile",
                        component: RegistrationTabsPage,
                    },
                    {
                        title: "Welcome Kit",
                        component: WelcomeKitPage,
                    },
                    {
                        title: "Announcement",
                        component: UserAnnouncementPage,
                    },
                ]
            },
            {
                title: 'Master', isHideSubmenu: true, iconname: "arrow-dropdown", subcomponents: [
                    {
                        title: "Modules",
                        component: ModulesPage,
                    },
                    {
                        title: "Services",
                        component: ServicesPage,
                    },
                    {
                        title: "Partners",
                        component: PartnersPage,
                    },

                ]
            },
            //    { title: 'User', component: MasterTabPage }

        ];
    }


    openPage(page) {
        // Reset the content nav to have just this page
        // we wouldn't want the back button to show in this scenario

        this.nav.setRoot(page.component);
    }
    toggleSubmenu(page) {
        if (page.isHideSubmenu) {
            page.isHideSubmenu = false;
            page.iconname = "arrow-dropup";
            return;
        }
        page.isHideSubmenu = true;
        page.iconname = "arrow-dropdown";
    }

}