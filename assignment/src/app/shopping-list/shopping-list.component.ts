import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-shopping-list',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './shopping-list.component.html',
  styleUrl: './shopping-list.component.scss'
})
export class ShoppingListComponent{

items: string[]=[];
newItem: string='';
additem()
{
  this.items.push(this.newItem)
  this.newItem=''
}
deletItem(index:number) {
  this.items.splice(index,1)
  }
}

