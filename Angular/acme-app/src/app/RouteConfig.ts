import{Routes} from "@angular/router";
import { WelcomeComponent } from "./welcome.component";
import { ProductListComponent } from "./productlist.component";
import { ProductDetail } from "./productdetail.component";

export const RouteArray:Routes=[
    {path:"",component:WelcomeComponent},
    {path:'Home',component:WelcomeComponent},
    {path:'ProductList',component:ProductListComponent},
    {path:'ProductDetail',component:ProductDetail}
];