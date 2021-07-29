import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Fre1Component } from './fre1.component';

describe('Fre1Component', () => {
  let component: Fre1Component;
  let fixture: ComponentFixture<Fre1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Fre1Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Fre1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
