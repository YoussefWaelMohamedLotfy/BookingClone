import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from './Shared/Components/not-found/not-found.component';
import { StaysComponent } from './Models/Stays/Stays-Component/Stays.component';
import { ReviewsComponent } from './Models/Reviews/Reviews-Component/Reviews.component';

const routes: Routes = [
  { path: 'Stays', component: StaysComponent },
  { path: 'Reviews', component: ReviewsComponent },
  { path: '', redirectTo: '/Stays', pathMatch: 'full' },
  { path: '**', component: NotFoundComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
