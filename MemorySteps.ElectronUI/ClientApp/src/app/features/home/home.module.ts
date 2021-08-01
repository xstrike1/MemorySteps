import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home.component';
import { RouterModule } from '@angular/router';
import { FlexLayoutModule } from '@angular/flex-layout';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatCardModule } from '@angular/material/card';
import { DashboardComponent } from '../dashboard/dashboard.component';
import { DashboardModule } from '../dashboard/dashboard.module';

export const routes = [
    {
      path: '',
      component: HomeComponent,
      pathMatch: 'full',
      data: {
        breadcrumb: 'Home'
      }
    }
  ];
  
  @NgModule({
    declarations: [
        HomeComponent
    ],
    imports: [
      CommonModule,
      FlexLayoutModule,
      MatProgressSpinnerModule,
      MatCardModule,
      RouterModule.forChild(routes),
      DashboardComponent,
      DashboardModule
    ]
  })
  export class HomeModule {
      constructor() { }
  }