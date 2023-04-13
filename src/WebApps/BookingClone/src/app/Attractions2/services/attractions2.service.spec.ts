import { TestBed } from '@angular/core/testing';

import { Attractions2Service } from './attractions2.service';

describe('Attractions2Service', () => {
  let service: Attractions2Service;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(Attractions2Service);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
