import { Component } from "@angular/core";

export class User {
    id: number;
    Name: string;
}
@Component({
    selector: "my-app",
    template: `
  <h1>{{title}}</h1>

  <p>Users:</p>
  <ul>
    <li *ngFor="let user of users">
      {{ hero.name }}
      </li>
  </ul>
  `
})

export class AppComponent {
    title = "Users";
    user: User = {
        id: 1,
        Name: "Waqas"
    };
}