import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Person } from '../models/person';

@Component({
  selector: 'app-child',
  template: ` <div class="container"><div class="row"><div class="card card-body" style="width: 18rem;"><div *ngFor="let person of personList"><div class="card-title"><span> FirstName: {{person.firstName}}</span></div>
  <div class="card-title"[hidden]="person.lastName === 'Moshe'"><span> LastName: {{person.lastName}}</span></div>
  <div class="card-title" *ngIf="person.age !==35"><span> Age: {{person.age}}</span></div>
  <div> </div></div><button  class="btn btn-primary" (click)="SendInformationToTheParent()">Click Child</button></div></div></div>
  `,
  styleUrls: ['./child.component.scss']
})
export class ChildComponent implements OnInit {

  @Input() personList = new Array<Person>();
  @Output() childData = new EventEmitter<any>();
  constructor() { }

  ngOnInit() {
  }

  SendInformationToTheParent(){
    this.childData.emit('This comes from the Child Component');
  }
}
