import { Component, EventEmitter, Input, input, Output } from '@angular/core';
import { AddItemComponent } from "../add-item/add-item.component";
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-view-item',
  standalone: true,
  imports: [AddItemComponent,CommonModule],
  templateUrl: './view-item.component.html',
  styleUrl: './view-item.component.scss'
})
export class ViewItemComponent {
  
  countvalue: number =0;
  items:string[]=[];
  
  deleteItem(index: number) {
    this.items.splice(index,1)
    this.countvalue=this.items.length;
  }
  
  addNewItem(newItem:string) {
    this.items.push(newItem);
    this.countvalue=this.items.length;
  }
  
}
