import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EdithComponent } from './edith.component';

describe('EdithComponent', () => {
  let component: EdithComponent;
  let fixture: ComponentFixture<EdithComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EdithComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EdithComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
