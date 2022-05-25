import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VladimirComponent } from './vladimir.component';

describe('VladimirComponent', () => {
  let component: VladimirComponent;
  let fixture: ComponentFixture<VladimirComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VladimirComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(VladimirComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
