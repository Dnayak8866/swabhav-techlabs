import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';
import { AppComponent } from './app.component';
import {WelcomeComponent} from './welcome.component';
import {RouteArray} from './RouteConfig';
 
import { RouterModule } from '@angular/router';
import { ProductListComponent } from './productlist.component';
import {ProductDetail} from './productdetail.component';
import {StarRating} from './starrating.component';
import {ProductDataService} from './Services/ProductDataService';
import { HttpModule } from '@angular/http';
@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponent,
    ProductListComponent,
    ProductDetail,
    StarRating,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    RouterModule.forRoot(RouteArray)

  ],
  providers: [ProductDataService],
  bootstrap: [AppComponent]
})
export class AppModule { }
