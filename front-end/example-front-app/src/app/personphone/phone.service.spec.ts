import { TestBed } from '@angular/core/testing';

import { PersonPhoneService } from './personphone.service';

describe('PersonPhoneService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: PersonPhoneService = TestBed.get(PersonPhoneService);
    expect(service).toBeTruthy();
  });
});
