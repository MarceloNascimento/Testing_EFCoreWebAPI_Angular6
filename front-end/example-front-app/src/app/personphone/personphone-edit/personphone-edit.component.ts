import { IPersonPhone } from './../iperson-phone';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { PersonPhoneService } from '../personphone.service';

@Component({
  selector: 'app-personphone-edit',
  templateUrl: './personphone-edit.component.html',
  styleUrls: ['./personphone-edit.component.css']
})
export class PersonphoneEditComponent implements OnInit {

  FormPersonPhone = new FormGroup({
    personName: new FormControl("", Validators.required),
    phoneNumber: new FormControl("", Validators.required),
    phoneNumberTypeID: new FormControl("", Validators.required)
  });

  public personId: number;
  public phoneNumber: string;
  public sub: any;
  public personphone: IPersonPhone;

  constructor(private currentRoute: ActivatedRoute,
    private personPhoneService: PersonPhoneService
    //, private phoneTypeService: PhoneTypeService
       , private router: Router) {
    this.personId = 0;
    this.phoneNumber = "";

  }

  ngOnInit(): void {
   this.currentRoute.params.subscribe(params => {

      this.personId = params['personId'];
      this.phoneNumber = (params['phoneNumber']).toString();
      this.loadData();
    });

  }


  protected loadData(): void {
    if (this.personId != null && this.personId > 0 && this.phoneNumber.length > 0) {

      this.personPhoneService.get(this.personId, this.phoneNumber).subscribe(response => {
        this.FormPersonPhone.controls.personName.setValue(response.data.personPhoneObjects[0].personName);
        this.FormPersonPhone.controls.phoneNumber.setValue(response.data.personPhoneObjects[0].phoneNumber);
       this.FormPersonPhone.controls.phoneNumberTypeID.setValue(response.data.personPhoneObjects[0].phoneNumberTypeID);
      });

    }
  }

  onReset() {
    this.FormPersonPhone.reset();
  }

  // ngOnDestroy() {
  //   this.sub.unsubscribe();
  // }

  voltar(){
    this.router.navigate(['phones']);
  }

  //TODO: Define a better place for shared functions with team
  numbersOnlyValidator(event: any) {
    const pattern = /^[0-9\-]*$/;
    if (!pattern.test(event.target.value)) {
      event.target.value = event.target.value.replace(/[^0-9\-]/g, "");
    }
  }



}
