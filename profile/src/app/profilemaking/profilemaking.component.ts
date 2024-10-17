import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { ActiveProjectPipe } from '../project.pipe';
import { FormArray, FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { NgSelectModule } from '@ng-select/ng-select';

interface  Address {
  AddressLine1: FormControl<string|null>;
  AddressLine2: FormControl<string|null>;
  City: FormControl<string|null>;
}
interface ProfileForm {
  fname:FormControl <string|null>;
  lname: FormControl<string|null>;
  email: FormControl<string|null>;
  phoneNumber:FormControl<number|null>;
  address:FormGroup<Address>;
  project:FormControl<string|null>;
}

@Component({
  selector: 'app-profilemaking',
  standalone: true,
  imports: [ReactiveFormsModule,CommonModule,ActiveProjectPipe,NgSelectModule],
  templateUrl: './profilemaking.component.html',
  styleUrl: './profilemaking.component.scss'
})

export class ProfilemakingComponent {
 
  ProfileForm=new FormGroup<ProfileForm>({
  fname:new FormControl('',[Validators.required]),
  lname:new FormControl(''),
  email:new FormControl('',[Validators.required,Validators.email,Validators.pattern(('^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$'))]),
  phoneNumber:new FormControl(null,[Validators.required,Validators.minLength(10),Validators.pattern(/^\d{1,10}$/)]),
  address:new FormGroup({
    AddressLine1:new FormControl(''),
    AddressLine2:new FormControl(''),
    City:new FormControl('')

  }), 
  project:new FormControl(''),
  }); 
  projects= [
    { name: "Hilite", isActive: true },
    { name: "Lulu", isActive: true },
    { name: "Cordova School", isActive: true },
    { name: "Azure Heights Apartments", isActive: true },
    { name: "Greenfield Mall", isActive: true },
    { name: "Pinnacle Corporate Towers", isActive: true },
    { name: "Sunshine Valley Resort", isActive: true },
    { name: "Everest Office Park", isActive: false },
    { name: "Maplewood Villas", isActive: false },
    { name: "Sterling Shopping Complex", isActive: false }
  ]
  
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
