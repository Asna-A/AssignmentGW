import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AddNewItemService {

  private AddItemService=new Subject<string>();
  AddItemService$=this.AddItemService.asObservable();

  private SetCountService=new Subject<number>();
  SetCountService$=this.SetCountService.asObservable();
  
  setData(newItem:string)
  {
    this.AddItemService.next(newItem);
  }
  setCount(count:number)
  {
    this.SetCountService.next(count);
  }
  
}
