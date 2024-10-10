import { Component } from '@angular/core';

@Component({
  selector: 'app-alert-me',
  standalone: true,
  imports: [],
  templateUrl: './alert-me.component.html',
  styleUrl: './alert-me.component.scss'
})
export class AlertMeComponent {
  alertMessage(){
    alert("Hello World")
  }
}
