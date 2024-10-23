import { Directive, Input, TemplateRef } from '@angular/core';
import { ViewContainerRef } from '@angular/core';

@Directive({
  selector: '[appEmail]',
  standalone: true
})
export class EmailDirective {
  
  
  constructor(private view:ViewContainerRef,private tref:TemplateRef<string>) {
   
  }
  
  @Input() set appEmail(email:string|null|undefined)
  {
    if(email)
    {
      if(email.endsWith('@gmail.com'))
        {
          this.view.createEmbeddedView(this.tref);
        }
        else
        {
          this.view.clear();
        }
    }
    
  }

}
