import { CommonModule } from '@angular/common';
import { Component, EventEmitter, Input, Output } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-add-item',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './add-item.component.html',
  styleUrl: './add-item.component.scss'
})
export class AddItemComponent {

  @Input() count: number=0;
  @Output() newItemEvent=new EventEmitter<string>();
  newItem: string='';

  addNewItem(value: string) {
    this.newItemEvent.emit(this.newItem);
  }

}

