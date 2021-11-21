import { PersonPhoneModule } from './personphone.module';

describe('PersonphoneModule', () => {
  let personphoneModule: PersonPhoneModule;

  beforeEach(() => {
    personphoneModule = new PersonPhoneModule();
  });

  it('should create an instance', () => {
    expect(personphoneModule).toBeTruthy();
  });
});
