import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FlexLayoutModule } from '@angular/flex-layout';
import { MatListModule } from '@angular/material/list';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { MatToolbarModule } from '@angular/material/toolbar'; 
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MaterialModule } from './material-module';
import { AppComponent } from './app.component';
import { TitlebarComponent } from './features/ui/titlebar/titlebar.component';
import { HomeComponent } from './features/home/home.component';
import { SharedService } from './shared.service';
import { GradientDirective } from './gradient/gradient.directive';
import { GradientService } from './gradient/gradient.service';
import { MenuListItemComponent } from './features/ui/menu-list-item/menu-list-item.component';
import { DashboardComponent } from './features/dashboard/dashboard.component';
import { FeaturesComponent } from './features/features.component';
import { AppRoutingModule } from './app-routing.module';

@NgModule({
  declarations: [
    AppComponent,
    TitlebarComponent,
    HomeComponent,
    GradientDirective,
    MenuListItemComponent,
    FeaturesComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatSidenavModule,
    MaterialModule,
    MatButtonModule,
    MatIconModule,
    // RouterModule.forRoot([
    //   { path: '', component: HomeComponent, pathMatch: 'full' },
    //   { path: 'titlebar', component: TitlebarComponent },
    // ]),
    FlexLayoutModule,
    MatListModule,
    AppRoutingModule,
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
