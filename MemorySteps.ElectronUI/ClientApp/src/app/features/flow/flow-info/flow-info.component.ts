import { Component,  Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {MatCardModule} from '@angular/material/card';

@Component({
  selector: 'app-flow-info',
  templateUrl: './flow-info.component.html',
  styleUrls: ['./flow-info.component.css']
})
export class FlowInfoComponent  {

  private url: string = '';

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) 
    {
        this.url = baseUrl;
    }

    startConfig(){
      this.http.get<any>(this.url + "process/startregister").subscribe();
    }
    stopConfig(){
      this.http.get<any>(this.url + "process/stopregister").subscribe();
  }

}
