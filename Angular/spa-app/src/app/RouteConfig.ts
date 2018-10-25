
import {Routes} from '@angular/router';
import { HomeComponent } from './home.component';
import { CareerComponent } from './career.component';
import { NotFound } from './notfound.component';
import { AboutComponent } from './about.component';
import { ServiceComponent } from './service.component';

export const RouteArray:Routes=[
    {path:"",component:HomeComponent},
    {path:'Home',component:HomeComponent},
    {path:'Career',component:CareerComponent},
    {path:'About',component:AboutComponent},
    {path:'service',component:ServiceComponent},
    {path:'service/:id',component:ServiceComponent},
    {path:'**',component:NotFound}
   
];