import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { FeaturesComponent } from './features/features.component';


const routes: Routes = [
    { path: '', pathMatch: 'full', redirectTo: 'home' },
    {
        path: '',
        component: FeaturesComponent,
        children: [
            { path: 'home', loadChildren: () => import('./features/dashboard/dashboard.module').then(m => m.DashboardModule) },
            { path: 'flow',  loadChildren: () => import('./features/flow/flow.module').then(m => m.FlowModule) }
        ],
    } 
];

@NgModule({
    imports: [
        RouterModule.forRoot(routes, { relativeLinkResolution: 'legacy' })
    ],
    exports: [RouterModule],
    providers: []
})
export class AppRoutingModule { }