import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from './Shared/Components/not-found/not-found.component';
import { StaysComponent } from './Shared/Components/stays/stays.component';
import { HotelsComponent } from './Hotels/Components/hotels/hotels.component';
import { combineLatest } from 'rxjs';
import { HotelDetailsComponent } from './Hotels/Components/hotel-details/hotel-details.component';

const routes: Routes = [
  { path: 'Stays', component: StaysComponent },
  { path: '', redirectTo: '/Stays', pathMatch: 'full' },
  { path: 'Hotels', component: HotelsComponent },
  { path: 'HotelDetails/:id', component: HotelDetailsComponent },
  { path: '**', component: NotFoundComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
