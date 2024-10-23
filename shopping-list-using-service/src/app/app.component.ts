import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { AddItemComponent } from "./add-item/add-item.component";
import { ViewItemComponent } from "./view-item/view-item.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, AddItemComponent, ViewItemComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'shopping-list-using-service';
}
