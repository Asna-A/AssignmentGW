import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { ActiveProjectPipe } from '../project.pipe';
import {  FormControl, FormGroup,ReactiveFormsModule, Validators } from '@angular/forms';
import { NgSelectModule } from '@ng-select/ng-select';
import { BgColorDirective } from '../bg-color.directive';
import { EmailDirective } from '../email.directive';


interface  Address {
  addressLine1: FormControl<string|null>;
  addressLine2: FormControl<string|null>;
  city: FormControl<string|null>;
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
  imports: [ReactiveFormsModule,CommonModule,ActiveProjectPipe,NgSelectModule,BgColorDirective,EmailDirective],
  templateUrl: './profilemaking.component.html',
  styleUrl: './profilemaking.component.scss'
})

export class ProfilemakingComponent {
 
  profileForm=new FormGroup<profileForm>({
  fname:new FormControl('',[Validators.required]),
  lname:new FormControl(''),
  email:new FormControl('',[Validators.required,Validators.email,Validators.pattern(('^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$'))]),
  phoneNumber:new FormControl(null,[Validators.required,Validators.maxLength(10),Validators.pattern(/^\d{1,10}$/)]),
  address:new FormGroup({
    addressLine1:new FormControl(''),
    addressLine2:new FormControl(''),
    city:new FormControl('')

  }), 
  project:new FormControl(''),
  }); 
  projects= [
    { id : 1 ,name: "Hilite", isActive: true },
    { id : 2 ,name: "Lulu", isActive: true },
    { id : 3 ,name: "Cordova School", isActive: true },
    { id : 4 ,name: "Greenfield Mall", isActive: true },
    { id : 5 ,name: "Azure Heights Apartments", isActive: true },
    { id : 6 ,name: "Pinnacle Corporate Towers", isActive: true },
    { id : 7 ,name: "Sunshine Valley Resort", isActive: true },
    { id : 8 ,name: "Everest Office Park", isActive: false },
    { id : 9 ,name: "Maplewood Villas", isActive: false },
    { id : 10 ,name: "Sterling Shopping Complex", isActive: false }
  ]
  
  
  result:boolean|false=false;
  employeeDetails:FormGroup<profileForm>|null=null;

  getselectedProject(projectId:string|null|undefined):string |undefined{
  var id=Number(projectId)
  var project= this.projects.find(project=>project.id==id)
  return project?.name
}
  onSubmit()
  {
    if(this.profileForm.valid)
    {
      this.result=true 
      this.employeeDetails=this.profileForm
    }
    else
    {
      this.result=false
    }
  }
}
