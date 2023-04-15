import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from './Shared/Components/not-found/not-found.component';
import { StaysComponent } from './Stays/Stays-Component/Stays.component';
import { ReviewsComponent } from './Reviews/Reviews-Component/Reviews.component';
import {OffersComponent} from './Offers/Component/offers/offers.component'
import { LoginComponent } from './Login/Component/Login/Login.component';
import { RatingComponent } from './Rating/Component/Rating/Rating.component';
import { FormsComponent } from './UserForm/Components/forms/forms.component';
import { UserAcountComponent } from './UserForm/user-acount/user-acount.component';

const routes: Routes = [
  { path: 'Stays', component: StaysComponent },
  { path: 'Login', component: LoginComponent },
  { path: 'Offers', component: OffersComponent },
  { path: 'Reviews', component: ReviewsComponent },
  { path: 'Rating', component: RatingComponent },
  { path: 'Forms', component: FormsComponent },
  { path: 'UserAcount', component: UserAcountComponent },
  { path: '', redirectTo: 'Stays', pathMatch: 'full' },
  { path: '**', component: NotFoundComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
