import { Component } from '@angular/core';
import { AddNewItemService } from '../add-new-item.service';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { takeUntilDestroyed } from '@angular/core/rxjs-interop';
@Component({
  selector: 'app-view-item',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './view-item.component.html',
  styleUrl: './view-item.component.scss'
})
export class ViewItemComponent {

  items:string[]=[];
  count!:number;
  
  constructor(private AddItemService:AddNewItemService) {}
    
  ngOnInit()
  {
    this.AddItemService.AddItemService$.pipe(takeUntilDestroyed(this.destroyRef)).subscribe(newItem=>this.addData(newItem));
  }
  
  addData(newItem:string) {
    this.items.push(newItem); 
    this.count=this.items.length;
    this.setCount(this.count);
  }
  setCount(count:number)
  {
    this.AddItemService.setCount(count);
  }

  deleteItem(index:number)
  {
    this.items.splice(index,1);
    this.count=this.items.length;
    this.setCount(this.count);
  }

}
