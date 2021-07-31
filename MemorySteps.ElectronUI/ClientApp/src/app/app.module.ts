import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { MatToolbarModule } from '@angular/material/toolbar'; 
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';

import { MaterialModule } from './material-module';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { TitlebarComponent } from './titlebar/titlebar.component';
import { HomeComponent } from './home/home.component';
import { SharedService } from './shared.service';
import { GradientDirective } from './gradient/gradient.directive';
import { GradientService } from './gradient/gradient.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    TitlebarComponent,
    HomeComponent,
    GradientDirective
  ],
  imports: [
    BrowserModule,//.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatSidenavModule,
    MaterialModule,
    MatButtonModule,
    MatIconModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'titlebar', component: TitlebarComponent },
    ])
  ],
  entryComponents: [
    TitlebarComponent
  ],
  providers: [
    SharedService,
    GradientService
  ],
  bootstrap: [
    AppComponent,
    TitlebarComponent
  ]
})
export class AppModule { }
