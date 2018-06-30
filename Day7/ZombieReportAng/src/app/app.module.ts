import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {RouterModule, Routes} from '@angular/router';

import { AppComponent } from './app.component';
import { ZombieComponent } from './Zombie.component';
import { addStatusComponent } from './addStatus.component';
import { HttpClient } from 'selenium-webdriver/http';

const appRoutes:Routes = [
{path: 'addStatus', component:addStatusComponent},
{path: 'report', component:ZombieComponent},
{path: '', component:ZombieComponent},
];

@NgModule({
  declarations: [
    AppComponent, ZombieComponent, addStatusComponent ////add a comma here, then add Zombie Component 
  ],
  imports: [
    BrowserModule,
    //HttpClientModule,
    //FormsModule,  
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
