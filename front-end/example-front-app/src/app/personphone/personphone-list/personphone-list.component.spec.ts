import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PersonPhoneListComponent } from './personphone-list.component';

describe('PersonPhoneListComponent', () => {
  let component: PersonPhoneListComponent;
  let fixture: ComponentFixture<PersonPhoneListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PersonPhoneListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PersonPhoneListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
