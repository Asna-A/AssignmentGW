
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-leap-year',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './leap-year.component.html',
  styleUrl: './leap-year.component.scss'
})
export class LeapYearComponent {
  year:number|null=null;
  checked=false;
  isleapyear=false;

  checkLeapYear()
  {
    this.checked=true
    if(this.year!==null) {
      this.isleapyear=(this.year%400)===0||(this.year%100!==0 && this.year%4===0)
     }
  }

}



  
  
  
  

