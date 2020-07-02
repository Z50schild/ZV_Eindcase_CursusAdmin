import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule, HttpClient} from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {from} from 'rxjs';
import { CursusListComponent } from './cursus-list/cursus-list.component';
import { CustomDatePipe } from './shared/Pipes/custom.datepipe';


@NgModule({
  declarations: [
    AppComponent,
    CursusListComponent,
    CustomDatePipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
