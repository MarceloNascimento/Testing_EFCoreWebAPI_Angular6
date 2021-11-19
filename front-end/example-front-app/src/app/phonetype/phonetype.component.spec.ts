import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PhonetypeComponent } from './phonetype.component';

describe('PhonetypeComponent', () => {
  let component: PhonetypeComponent;
  let fixture: ComponentFixture<PhonetypeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PhonetypeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PhonetypeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
