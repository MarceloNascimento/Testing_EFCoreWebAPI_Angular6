import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { PersonphoneEditComponent } from './personphone/personphone-edit/personphone-edit.component';
import { PersonPhoneListComponent } from './personphone/personphone-list/personphone-list.component';

const routes: Routes = [

  {path: '', component: HomeComponent},

  {path: 'home', component: HomeComponent},

  {path: 'phones', component: PersonPhoneListComponent},

  {path: 'phones-edit/:personId/:phoneNumber', component: PersonphoneEditComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(
    routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
