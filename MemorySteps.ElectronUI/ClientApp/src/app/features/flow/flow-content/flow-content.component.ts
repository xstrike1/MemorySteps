import { Component, Input, OnInit } from '@angular/core';
import { UserAction } from 'src/app/flow.service';

@Component({
  selector: 'app-flow-content',
  templateUrl: './flow-content.component.html',
  styleUrls: ['./flow-content.component.css']
})
export class FlowContentComponent implements OnInit {
  
  @Input() flowActions: UserAction[] = new Array<UserAction>();

  constructor() {
  }

  ngOnInit(): void {
  }

}
