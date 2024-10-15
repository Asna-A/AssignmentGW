import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { StateTableComponent } from "./state-table/state-table.component";
import { GoogleComponent } from "./google/google.component";
import { NumbersComponent } from "./numbers/numbers.component";
import { NestedListComponent } from "./nested-list/nested-list.component";
import { AlertMeComponent } from "./alert-me/alert-me.component";
import { LeapYearComponent } from "./leap-year/leap-year.component";
import { ShoppingListComponent } from "./shopping-list/shopping-list.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, StateTableComponent, GoogleComponent, NumbersComponent, NestedListComponent, AlertMeComponent, LeapYearComponent, ShoppingListComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'assignment';
}
