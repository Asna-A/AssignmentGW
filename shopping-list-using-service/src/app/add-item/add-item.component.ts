import { Component } from '@angular/core';
import { AddNewItemService } from '../add-new-item.service';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-add-item',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './add-item.component.html',
  styleUrl: './add-item.component.scss'
})
export class AddItemComponent {
  newItem: string='';
  countvalue!:number;
  
  constructor(private AddItemService:AddNewItemService) {}

  ngOnInit()
  {
    this.AddItemService.SetCountService$.subscribe(count=>this.setCount(count));
  }

  addData() {
    this.AddItemService.setData(this.newItem);
  }
  setCount(count:number)
  {
    this.countvalue=count;
  }

}
