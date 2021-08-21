import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FlexLayoutModule } from '@angular/flex-layout';
import { MatListModule } from '@angular/material/list';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { MatToolbarModule } from '@angular/material/toolbar'; 
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MaterialModule } from './material-module';
import { AppComponent } from './app.component';
import { TitlebarComponent } from './features/ui/titlebar/titlebar.component';
import { GradientDirective } from './gradient/gradient.directive';
import { GradientService } from './gradient/gradient.service';
import { MenuListItemComponent } from './features/ui/menu-list-item/menu-list-item.component';
import { FeaturesComponent } from './features/features.component';
import { AppRoutingModule } from './app-routing.module';
import { FlowInfoComponent } from './features/flow/flow-info/flow-info.component';
import { FlowModule } from './features/flow/flow.module';
import { DashboardModule } from './features/dashboard/dashboard.module';

@NgModule({
  declarations: [
    AppComponent,
    TitlebarComponent,
    GradientDirective,
    MenuListItemComponent,
    FeaturesComponent,
    FlowInfoComponent
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
    FlexLayoutModule,
    MatListModule,
    AppRoutingModule,
    FlowModule,
    DashboardModule
  ],
  entryComponents: [
    TitlebarComponent
  ],
  providers: [
    GradientService
  ],
  bootstrap: [
    AppComponent,
    TitlebarComponent
  ]
})
export class AppModule { }
