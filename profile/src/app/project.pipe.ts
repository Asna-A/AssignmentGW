import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'activeProject',
  standalone: true
})
export class ActiveProjectPipe implements PipeTransform {

  transform(value: any[], isActive: boolean): any {

    if(value)
      return value.filter((item:any)=>item.isActive==true)
  }

}
