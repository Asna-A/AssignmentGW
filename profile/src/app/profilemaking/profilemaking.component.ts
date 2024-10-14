import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

import { FormArray, FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';

interface  Address {
  AddressLine1: string;
  AddressLine2: string;
  City: string;
}
interface ProfileForm {
  fname: string|null;
  lname: string|null;
  email: string|null;
  phoneNumber: number|null;
  address:Address|null;
}

@Component({
  selector: 'app-profilemaking',
  standalone: true,
  imports: [ReactiveFormsModule,CommonModule],
  templateUrl: './profilemaking.component.html',
  styleUrl: './profilemaking.component.scss'
})

export class ProfilemakingComponent {
 
  ProfileForm=new FormGroup({
  fname:new FormControl('',[Validators.required]),
  lname:new FormControl(''),
  email:new FormControl('',[Validators.required,Validators.email,Validators.pattern(('^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$'))]),
  phoneNumber:new FormControl('',[Validators.required,Validators.maxLength(10)]),
  address:new FormGroup({
    AddressLine1:new FormControl(''),
    AddressLine2:new FormControl(''),
    City:new FormControl('')
  }), 
  }); 
  employee:ProfileForm|null=null;
  result:boolean|false=false;
  onSubmit()
  {
    if(this.ProfileForm.valid)
    {
      this.result=true  
    }
    else
    {
      this.result=false
    }
  }
}


