import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ZombieComponent } from './Zombie.component';


@NgModule({
  declarations: [
    AppComponent, ZombieComponent ////add a comma here, then add Zombie Component 
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
