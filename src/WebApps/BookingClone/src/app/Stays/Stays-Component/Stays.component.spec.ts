/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { StaysComponent } from './Stays.component';

describe('StaysComponent', () => {
  let component: StaysComponent;
  let fixture: ComponentFixture<StaysComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ StaysComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(StaysComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
