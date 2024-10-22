
import { Routes } from '@angular/router';
import { AlertMeComponent } from './alert-me/alert-me.component';
import { GoogleComponent } from './google/google.component';
import { LeapYearComponent } from './leap-year/leap-year.component';
import { NestedListComponent } from './nested-list/nested-list.component';
import { NumbersComponent } from './numbers/numbers.component';
import { ShoppingListComponent } from './shopping-list/shopping-list.component';
import { StateTableComponent } from './state-table/state-table.component';

export const routes: Routes = [
    {path:'alert-me',component:AlertMeComponent},
    {path:'google',component:GoogleComponent},
    {path:'leap-year',component:LeapYearComponent},    
    {path:'nested-list',component:NestedListComponent},
    {path:'numbers',component:NumbersComponent},
    {path:'shopping-list',component:ShoppingListComponent},
    {path:'state-table',component:StateTableComponent},
];
