"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
exports.__esModule = true;
var core_1 = require("@angular/core");
var AppComponent = (function () {
    function AppComponent() {
        this.title = "Users";
        this.users = [];
        //myHero = this.heroes[0];
    }
    return AppComponent;
}());
AppComponent = __decorate([
    core_1.Component({
        selector: "my-app",
        template: "\n  <h1>{{title}}</h1>\n  <p>Heroes:</p>\n  <ul>\n    <li *ngFor=\"let user of users\">\n      {{ hero.name }}\n      </li>\n  </ul>\n  "
    })
], AppComponent);
exports.AppComponent = AppComponent;