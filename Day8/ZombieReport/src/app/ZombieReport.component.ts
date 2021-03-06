import { Component } from '@angular/core';
import { PersonStatus } from './entities/PersonStatus'
import { PersonStatusService } from './services/PersonStatusService'

@Component({
  selector: 'zombieReport',
  templateUrl: './zombieReport.component.html',
  styleUrls: ['./zombieReport.component.css']
})
export class ZombieReportComponent {
  public title:string = 'Zombie Status Report';
  public statuses:PersonStatus[] = [];

  public constructor(personStatusService: PersonStatusService) {
    personStatusService.getAll().subscribe(result => {
      for (let status of result) {
        this.statuses.push(status);
      }
    }, error => { 
      console.log(error)
    });
    /*
    this.statuses = [
      {firstName:'Tom',lastName:'Masters',statusId:4,statusDescription:'Unknown'},
      {firstName:'Bob',lastName:'Masters',statusId:2,statusDescription:'Zombie'},
      {firstName:'John',lastName:'Masters',statusId:1,statusDescription:'Alive'},
      {firstName:'Joe',lastName:'Masters',statusId:3,statusDescription:'Dead'},
      {firstName:'Steve',lastName:'Masters',statusId:2,statusDescription:'Zombie'}     
    ];
    */
  }
}