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
  
  @Output() deleteItemEvent=new EventEmitter<number>();
  @Input() items:string[]=[];
  index: number | undefined;
  
  deleteItem(value: number) {
    this.deleteItemEvent.emit(this.index);
  }
  
  
  
}
