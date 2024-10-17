import { Directive, ElementRef, HostListener, Input } from '@angular/core';

@Directive({
  selector: '[appBgColor]',
  standalone: true
})
export class BgColorDirective {

  
  constructor(private el:ElementRef) { }
  @HostListener('mouseenter') onMouseenter()
  {
    this.highlight("yellow");
  }
  @HostListener('mouseleave') onMouseleave()
  {
    this.highlight('');
  }
  private highlight(color:string)
  {
    this.el.nativeElement.style.backgroundColor=color;
  }
}
