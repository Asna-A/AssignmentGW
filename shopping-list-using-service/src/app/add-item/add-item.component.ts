import { Component } from '@angular/core';
import { AddNewItemService } from '../add-new-item.service';
import { FormsModule } from '@angular/forms';
import { takeUntilDestroyed } from '@angular/core/rxjs-interop';

@Component({
  selector: 'app-add-item',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './add-item.component.html',
  styleUrl: './add-item.component.scss'
})
export class AddItemComponent {
  newItem: string='';
  countvalue:number=0;
  
  constructor(private AddItemService:AddNewItemService,private destroyRef:DestroyRef) {}

  ngOnInit()
  {
    this.AddItemService.SetCountService$.pipe(takeUntilDestroyed(this.destroyRef)).subscribe(count=>this.setCount(count));
  }

  addData() {
    this.AddItemService.setData(this.newItem);
  }
  setCount(count:number)
  {
    this.countvalue=count;
  }

}
