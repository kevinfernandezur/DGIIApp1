import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContribuyentesComponent } from './components/contribuyentes/contribuyentes.component';

const routes: Routes = [
  { path: '', component: ContribuyentesComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
