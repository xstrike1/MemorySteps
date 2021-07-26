import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'app-titlebar',
    templateUrl: './titlebar.component.html',
    styleUrls: ['./titlebar.component.css']
})
export class TitlebarComponent {
    private url: string = '';

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) 
    {
        this.url = baseUrl;
    }
   
    closeWindow(){
        this.http.post<any>(this.url + "mainwindow/close","").subscribe();
    }
    maxWindow(){
        this.http.post<any>(this.url + "mainwindow/max","").subscribe();
    }
    minWindow(){
        this.http.post<any>(this.url + "mainwindow/min","").subscribe();
    }
}
