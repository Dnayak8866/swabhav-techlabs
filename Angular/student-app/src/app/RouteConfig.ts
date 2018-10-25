
import {Routes} from '@angular/router';
import { HomeComponent } from './home.component';
import { AddStudentComponent } from './addstudent.component';
import { EditStudentComponent } from './editstudent.component';
export const RouteArray:Routes=[
    {path:"",component:HomeComponent},
    {path:"Home",component:HomeComponent},

    {path:'Add',component:AddStudentComponent},
    {path:'edit',component:EditStudentComponent}
];