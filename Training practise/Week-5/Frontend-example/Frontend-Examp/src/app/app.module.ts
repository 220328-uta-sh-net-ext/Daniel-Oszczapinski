import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HomePageComponent } from './home-page/home-page.component';
import { DanielInfoComponent } from './daniel-info/daniel-info.component';

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    DanielInfoComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
