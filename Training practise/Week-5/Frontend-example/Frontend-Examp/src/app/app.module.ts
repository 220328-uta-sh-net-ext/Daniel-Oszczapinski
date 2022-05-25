import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HomePageComponent } from './home-page/home-page.component';
//import { DanielInfoComponent } from './daniel-info/daniel-info.component';
//import { EdithComponent } from './edith/edith.component';
//import { VladimirComponent } from './vladimir/vladimir.component';
//import { BricesonComponent } from './briceson/briceson.component';
import { FormsModule } from '@angular/forms';
import { PersonComponent } from './person/person.component';
import { RosterComponent } from './roster/roster.component';

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    //DanielInfoComponent,
    //EdithComponent,
    //VladimirComponent,
   //BricesonComponent,
    PersonComponent,
    RosterComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
