import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PersonComponent } from './person/person.component';
import { PhoneComponent } from './phone/phone.component';
import { PhonetypeComponent } from './phonetype/phonetype.component';

const routes: Routes = [

  {path: '', component: PersonComponent},

  {path: 'person-list', component: PersonComponent},

  {path: 'phones-list', component: PhoneComponent},

  {path: 'phonestypes-list', component: PhonetypeComponent},

];

@NgModule({
  imports: [RouterModule.forRoot(
    routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
