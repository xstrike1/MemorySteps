import { Component, Input, OnInit } from '@angular/core';
import { UserAction } from 'src/app/flow.service';

@Component({
  selector: 'app-flow-element',
  templateUrl: './flow-element.component.html',
  styleUrls: ['./flow-element.component.css']
})
export class FlowElementComponent implements OnInit {

  @Input() action: UserAction = new UserAction(-1,-1);
  @Input() lastElement: boolean = false;

  constructor() { }

  ngOnInit(): void {
  }

}
