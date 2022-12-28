import { AdminviewComponent } from './adminview/adminview.component';
import { AddroomComponent } from './addroom/addroom.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminLayoutComponent } from './admin-layout.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  {path: '', component: AdminLayoutComponent, children:[
    {path: '', component: HomeComponent},
    {path: 'addroom', component: AddroomComponent},
    {path: 'adminview', component: AdminviewComponent},

 ]}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
