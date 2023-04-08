/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { StaysService } from './stays.service';

describe('Service: Stays', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [StaysService]
    });
  });

  it('should ...', inject([StaysService], (service: StaysService) => {
    expect(service).toBeTruthy();
  }));
});
