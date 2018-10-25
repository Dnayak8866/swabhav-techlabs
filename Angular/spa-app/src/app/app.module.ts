import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import {FormsModule} from '@angular/forms';
import {RouterModule} from '@angular/router';
import { RouteArray } from './RouteConfig';
import {HomeComponent} from './home.component';
import {CareerComponent} from './career.component';
import {NotFound} from './notfound.component';
import { AboutComponent } from './about.component';
import {ServiceComponent} from './service.component';
@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    CareerComponent,
    NotFound,
    AboutComponent,
    ServiceComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(RouteArray),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
