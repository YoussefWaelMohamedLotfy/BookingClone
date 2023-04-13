import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EgyptCitiesComponent } from './egypt-cities.component';

describe('EgyptCitiesComponent', () => {
  let component: EgyptCitiesComponent;
  let fixture: ComponentFixture<EgyptCitiesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EgyptCitiesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EgyptCitiesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
