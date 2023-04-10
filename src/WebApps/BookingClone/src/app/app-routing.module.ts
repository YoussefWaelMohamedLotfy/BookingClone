import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from './Shared/Components/not-found/not-found.component';
import { StaysComponent } from './Stays/Component/Stays.component';
import { ReviewsComponent } from './Reviews/Reviews-Component/Reviews.component';

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
