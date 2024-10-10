import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-state-table',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './state-table.component.html',
  styleUrl: './state-table.component.scss'
})
export class StateTableComponent {
  states=[
    { name: 'Andhra', chiefMinister: 'Jagan', capital: 'Amaravati' },
    { name: 'Telangana', chiefMinister: 'KCR', capital: 'Hyderabad' },
    { name: 'Karnataka', chiefMinister: 'Bommai', capital: 'Bangalore' },
    { name: 'Maharashtra', chiefMinister: 'Uddhav Thackeray', capital: 'Mumbai' },
    { name: 'Kerala', chiefMinister: 'Pinarayi', capital: 'Thiruvananthapuram' },
  ];
}
