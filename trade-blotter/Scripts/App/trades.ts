import { Component } from "@angular/core";
@Component({
  selector: "my-app",
  template: `<h1>{{title}}</h1><p>Heroes:</p><ul><li *ngFor="let user of users">{{ hero.name }}</li></ul>`
})

export class AppComponent {
  title = "Users";
  users = [];
}
