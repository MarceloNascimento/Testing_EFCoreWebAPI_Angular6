import { PersonPhoneModule } from './personphone.module';

describe('PhoneModule', () => {
  let phoneModule: PersonPhoneModule;

  beforeEach(() => {
    phoneModule = new PersonPhoneModule();
  });

  it('should create an instance', () => {
    expect(phoneModule).toBeTruthy();
  });
});
