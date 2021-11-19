import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { ReactiveFormsModule } from "@angular/forms";

import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';

import { PersonComponent } from './person/person.component';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { PhoneComponent } from './phone/phone.component';
import { PhonetypeComponent } from './phonetype/phonetype.component';

@NgModule({
  declarations: [
    AppComponent,
    PersonComponent,
    PhoneComponent,
    PhonetypeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
