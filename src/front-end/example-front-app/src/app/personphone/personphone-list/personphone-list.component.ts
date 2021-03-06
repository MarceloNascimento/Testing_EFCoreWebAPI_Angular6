import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { IPersonPhone } from '../iperson-phone';
import { PersonPhoneService } from '../personphone.service';

@Component({
  selector: 'app-phone',
  templateUrl: './personphone-list.component.html',
  styleUrls: ['./personphone-list.component.css']
})
export class PersonPhoneListComponent implements OnInit {

  public personphones: IPersonPhone[]; //PersonPhone

  constructor(private _phoneService: PersonPhoneService
    , private _router: Router) { }

  ngOnInit() {
    this.LoadData();
  }


  LoadData():void {

    this._phoneService.getList().subscribe(response => {

      if (response.success && response.data.personPhoneObjects.length) {

        this.personphones = response.data.personPhoneObjects;

      }
    });


  }


  edit(personId: number, phoneNumber : string):void {
    this._router.navigate(['phones-edit', personId, phoneNumber]);
  }

}
