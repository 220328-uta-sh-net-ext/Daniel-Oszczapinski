import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BricesonComponent } from './briceson.component';

describe('BricesonComponent', () => {
  let component: BricesonComponent;
  let fixture: ComponentFixture<BricesonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BricesonComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BricesonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
