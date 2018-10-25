
import {Routes} from '@angular/router';
import { HomeComponent } from './home.component';

import { AddContactComponent } from './addcontact.component';
import { EditContactComponent } from './editcontact.component';
import { DeleteComponenet } from './delete.component';
import { LoginComponent } from './login.component';
export const RouteArray:Routes=[
    {path:"",component:HomeComponent},
    {path:'Home',component:HomeComponent},
    {path:'Home/:contact',component:HomeComponent},
    {path:'delete',component:DeleteComponenet},
    {path:'Add',component:AddContactComponent},
    {path:'login',component:LoginComponent},
    {path:'edit',component:EditContactComponent}

   
]