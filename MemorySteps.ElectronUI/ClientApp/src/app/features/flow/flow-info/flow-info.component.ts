import { Component,  Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { UserAction } from 'src/app/flow.service';

@Component({
  selector: 'app-flow-info',
  templateUrl: './flow-info.component.html',
  styleUrls: ['./flow-info.component.css']
})
export class FlowInfoComponent  implements OnInit{

  private url: string = '';
  flowAct: UserAction[] = [
    new UserAction(0, 2),
    new UserAction(1, 3)
  ]

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) 
  {
    this.url = baseUrl;
  }

  ngOnInit() {
  }

  startConfig(){
    this.http.get<any>(this.url + "process/startregister").subscribe();
  }
  stopConfig(){
    this.http.get<any>(this.url + "process/stopregister").subscribe();
  }

}
