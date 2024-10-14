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
  title = 'shoppinglist';

  countValue: number =0;
  items:string[]=[];
  
  deleteItem(index: number) {
    this.items.splice(index,1)
    this.countValue=this.items.length;
  }
  addNewItem(newItem:string) {
    this.items.push(newItem);
    this.countValue=this.items.length;
  }
  
}
