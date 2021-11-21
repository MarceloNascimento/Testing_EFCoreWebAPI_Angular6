import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PersonphoneEditComponent } from './personphone-edit.component';

describe('PersonphoneEditComponent', () => {
  let component: PersonphoneEditComponent;
  let fixture: ComponentFixture<PersonphoneEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PersonphoneEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PersonphoneEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
