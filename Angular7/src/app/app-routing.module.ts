import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RegistrationComponent } from './Registrationpage/registration/registration.component';
import { RegistrationpageComponent } from './registrationpage/registrationpage.component';


const routes: Routes = [
  {path:'',redirectTo:'registration',pathMatch:'full'},
  {path:'Registrationpage',component:RegistrationpageComponent},
  {path:'registration',children:[
    {path:'',component:RegistrationComponent}
]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
