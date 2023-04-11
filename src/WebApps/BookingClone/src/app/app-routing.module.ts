import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from './Shared/Components/not-found/not-found.component';
import { StaysComponent } from './Shared/Components/stays/stays.component';
import { HotelsComponent } from './Hotels/Components/hotels/hotels.component';
import { combineLatest } from 'rxjs';
import { HotelDetailsComponent } from './Hotels/Components/hotel-details/hotel-details.component';
import { AttractionsComponent } from './Attraction/Component/attractions/attractions.component';

import { AllRoomReservationsComponent } from './Reservations/RoomReservations/Components/all-room-reservations/all-room-reservations.component';
import { AllAttractionReservationsComponent } from './Reservations/AttractionReservations/Components/all-attraction-reservations/all-attraction-reservations.component';
import { CityComponent } from './City/city/city.component';
import { ContinentComponent } from './Continent/continent/continent.component';
import { CityDetailsComponent } from './City/city-details/city-details.component';
import { EgyptCitiesComponent } from './City/egypt-cities/egypt-cities.component';

const routes: Routes = [
  { path: 'attractions', component: AttractionsComponent },
  { path: 'Room/Reservations', component: AllRoomReservationsComponent },
  { path: 'Attraction/Reservations', component: AllAttractionReservationsComponent },
  { path: 'Stays', component: StaysComponent },
  { path: '', redirectTo: '/Room/Reservations', pathMatch: 'full' },
  { path: '', redirectTo: '/Stays', pathMatch: 'full' },
  // { path: 'Stays', component: StaysComponent },
  { path:'Continent',component: ContinentComponent },
  { path:'Continent/:id',component: ContinentComponent },
  { path:'city',component: CityComponent },
  { path:'CityDetails/:CountryID',component: CityDetailsComponent },

  { path:'egyptcities',component: EgyptCitiesComponent },

  // { path: 'Room/Reservations', component: AllRoomReservationsComponent },
  // { path: 'Attraction/Reservations', component: AllAttractionReservationsComponent },
  // { path: 'Hotels', component: HotelsComponent },
  // { path: 'HotelDetails/:id', component: HotelDetailsComponent },
  // { path: '', redirectTo: '/Room/Reservations', pathMatch: 'full' },

  { path: '**', component: NotFoundComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
