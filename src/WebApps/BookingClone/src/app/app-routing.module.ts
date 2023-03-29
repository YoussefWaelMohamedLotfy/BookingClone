import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from './Components/not-found/not-found.component';
import { StaysComponent } from './Components/stays/stays.component';

const routes: Routes = [
  { path: 'Stays', component: StaysComponent },
  { path: '', redirectTo: '/Stays', pathMatch: 'full' },
  { path: '**', component: NotFoundComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
