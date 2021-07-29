import { TestBed } from '@angular/core/testing';

import { PersonaSerService } from './persona-ser.service';

describe('PersonaSerService', () => {
  let service: PersonaSerService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PersonaSerService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
