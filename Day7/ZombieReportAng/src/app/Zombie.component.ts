import { Component } from '@angular/core';
import { PersonStatus } from './entities/PersonStatus';
import { PersonStatusService } from './services/PersonStatusService';

@Component({
  selector: 'Zombie',
  templateUrl: './Zombie.component.html',
  styleUrls: ['./Zombie.component.css']
})
export class ZombieComponent {
public title: string= 'Zombie Report';
public statuses: PersonStatus[] = [];
  
public constructor(personStatusService: PersonStatusService) {
  this.statuses = [];
  personStatusService.getAll().subscribe(result => {
    this.statuses.push(...result);
  }, error => {
    console.error(error)
  });

/*  this.statuses =[
  {firstName: 'Tom', lastName: 'Masters', statusId:4,statusDescription:'Unknown'},
  {firstName: 'Bob', lastName: 'Masters', statusId:2,statusDescription:'Zombie'},
  {firstName: 'John', lastName: 'Masters', statusId:1,statusDescription:'Alive'},
  {firstName: 'Joe', lastName: 'Masters', statusId:3,statusDescription:'Dead'},
  {firstName: 'Steve', lastName: 'Masters', statusId:2,statusDescription:'Zombie'}
  ];  */
}
}
