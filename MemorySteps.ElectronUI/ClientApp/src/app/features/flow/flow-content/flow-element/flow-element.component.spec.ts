import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FlowElementComponent } from './flow-element.component';

describe('FlowElementComponent', () => {
  let component: FlowElementComponent;
  let fixture: ComponentFixture<FlowElementComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FlowElementComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FlowElementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
