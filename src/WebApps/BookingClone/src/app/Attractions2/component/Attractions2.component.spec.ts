/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { Attractions2Component } from './Attractions2.component';

describe('Attractions2Component', () => {
  let component: Attractions2Component;
  let fixture: ComponentFixture<Attractions2Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Attractions2Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Attractions2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
