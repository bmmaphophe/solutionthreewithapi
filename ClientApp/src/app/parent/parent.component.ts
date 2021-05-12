import { Component, OnInit } from '@angular/core';
import { Person } from '../models/person';
import { PersonService } from '../services/person.service';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.scss']
})
export class ParentComponent implements OnInit {

  ChildInformation: string;
  personList : Array<Person>;

  constructor( private personService: PersonService) { }

  ngOnInit() {
    this.getData();
  }

  getData(){

    this.personService.getData().subscribe(res =>{
      this.personList = new Array<Person>();
      if(res){
        this.personList = res;
      }else{
        console.log("issue with the API");
      }
    })
  }

  ReviceingChildComponentInformation(data){
    this.ChildInformation = data;
  }

}
