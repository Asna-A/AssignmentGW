import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'activeProject',
  standalone: true
})
export class ActiveProjectPipe implements PipeTransform {

  transform(value: string, isActive: boolean): any {
    if(isActive==true)
    return value;
  }

}
