import { Component,  Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
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
