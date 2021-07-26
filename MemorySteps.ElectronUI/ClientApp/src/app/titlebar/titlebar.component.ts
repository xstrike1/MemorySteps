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
       // var win = remote.BrowserWindow.getFocusedWindow();
        //win?.close();
    }
    maxWindow(){
        //this.http.get(this.url + "api/mainwindow/close").subscribe;
    }
    minWindow(){
       // this.http.post(this.url + "mainwindow","");
    }
}
