import { IPersonPhone } from './../iperson-phone';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { PersonPhoneService } from '../personphone.service';
import { PersonPhone } from '../person-phone';
import { PersonPhoneRequest } from '../person-phone-request';

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
    this.personphone = new PersonPhone();

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
        this.personphone.id = response.data.personPhoneObjects[0].id;
        this.personphone.personID = response.data.personPhoneObjects[0].personID;
        this.personphone.personName = response.data.personPhoneObjects[0].personName;
        this.personphone.phoneNumber = response.data.personPhoneObjects[0].phoneNumber;
        this.personphone.phoneNumberTypeID = response.data.personPhoneObjects[0].phoneNumberTypeID;
        this.personphone.phoneNumberTypeName = response.data.personPhoneObjects[0].phoneNumberTypeName;

      });

    }
  }

  onReset() {
    this.FormPersonPhone.reset();
  }

  back(){
    this.router.navigate(['phones']);
  }

  update(): void {

    let request = new PersonPhoneRequest();
        request.PersonPhoneObjects = this.personphone;

    this.personPhoneService.update(request)
      .subscribe(
        sucesso => {
          console.info(`Register inserted with success ${sucesso}`);
          this.FormPersonPhone.reset();
          this.back();
        },
        error => console.error(error)
      );

  }



  //TODO: Define a better place for shared functions with team
  numbersOnlyValidator(event: any) {
    const pattern = /^[0-9\-]*$/;
    if (!pattern.test(event.target.value)) {
      event.target.value = event.target.value.replace(/[^0-9\-]/g, "");
    }
  }



}
