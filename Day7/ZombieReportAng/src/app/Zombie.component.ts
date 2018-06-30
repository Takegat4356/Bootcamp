import { Component } from '@angular/core';
import { PersonStatus } from 'e2e/src/entities/PersonStatus';

@Component({
  selector: 'Zombie',
  templateUrl: './Zombie.component.html',
  styleUrls: ['./Zombie.component.css']
})
export class ZombieComponent {
public title: string= 'Zombie Report';
public statuses: PersonStatus[] = [];
  
public constructor(personStatusService: PersonStatusService){
this.statuses =[
  {firstName: 'Tom', lastName: 'Masters', statusID:4,statusDescription:'Unknown'},
  {firstName: 'Bob', lastName: 'Masters', statusID:2,statusDescription:'Zombie'},
  {firstName: 'John', lastName: 'Masters', statusID:1,statusDescription:'Alive'},
  {firstName: 'Joe', lastName: 'Masters', statusID:3,statusDescription:'Dead'},
  {firstName: 'Steve', lastName: 'Masters', statusID:2,statusDescription:'Zombie'}
  ];  
}

}
