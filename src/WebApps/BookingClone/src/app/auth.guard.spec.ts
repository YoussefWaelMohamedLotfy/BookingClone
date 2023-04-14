import { TestBed } from '@angular/core/testing';

import { AUTHGuard } from './auth.guard';

describe('AUTHGuard', () => {
  let guard: AUTHGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(AUTHGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});
