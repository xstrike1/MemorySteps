import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FlowContentComponent } from './flow-content.component';

describe('FlowContentComponent', () => {
  let component: FlowContentComponent;
  let fixture: ComponentFixture<FlowContentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FlowContentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FlowContentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
