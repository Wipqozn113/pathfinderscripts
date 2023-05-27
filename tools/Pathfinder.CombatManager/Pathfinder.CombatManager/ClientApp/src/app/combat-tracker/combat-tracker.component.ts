import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-combat-tracker',
  templateUrl: './combat-tracker.component.html'
})
export class CombatTrackerComponent {
  public particpants: Participant[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Participant[]>(baseUrl + 'combat').subscribe(result => {
      this.particpants = result;
    }, error => console.error(error));
  }
}

interface Participant {
  name: string;
  initiative: number;
  ac: number;
  currentHp: number;
}

