import { Component } from '@angular/core';

import { RouterOutlet } from '@angular/router';
import { ProfilemakingComponent } from "./profilemaking/profilemaking.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, ProfilemakingComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'profile';

}