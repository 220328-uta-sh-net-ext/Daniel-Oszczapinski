import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HomePageComponent } from './home-page/home-page.component';
import { FormsModule } from '@angular/forms';
import { PersonComponent } from './person/person.component';
import { RosterComponent } from './roster/roster.component';
import { NavbarComponent } from './navbar/navbar.component';
import { SquarePipe } from './square.pipe';
import { AppRoutingModule } from './app-routing.module';

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    PersonComponent,
    RosterComponent,
    NavbarComponent,
    SquarePipe
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
