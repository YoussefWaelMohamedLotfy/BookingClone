import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContinenrDetailsComponent } from './continenr-details.component';

describe('ContinenrDetailsComponent', () => {
  let component: ContinenrDetailsComponent;
  let fixture: ComponentFixture<ContinenrDetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ContinenrDetailsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ContinenrDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
