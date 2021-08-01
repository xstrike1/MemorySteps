import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { FeaturesComponent } from './features/features.component';


const routes: Routes = [
    { path: 'dashboard', pathMatch: 'full', redirectTo: 'home' },
    {
        path: '',
        component: FeaturesComponent,
        children: [
            { path: '', loadChildren: () => import('./features/dashboard/dashboard.module').then(m => m.DashboardModule) }
        ]
    },
    
];

@NgModule({
    imports: [
        RouterModule.forRoot(routes)
    ],
    exports: [RouterModule],
    providers: []
})
export class AppRoutingModule { }