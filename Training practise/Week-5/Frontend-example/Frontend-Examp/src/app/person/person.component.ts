import { Component, Input, OnInit } from '@angular/core';
import { IPerson } from '../IPerson';
@Component({
  selector: 'person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})
export class PersonComponent implements OnInit {

  @Input() peep:IPerson = {
    name: "",
    about: "",
    intrest: ""
  }
  constructor() { }
  ngOnInit(): void {
  }
  
}
