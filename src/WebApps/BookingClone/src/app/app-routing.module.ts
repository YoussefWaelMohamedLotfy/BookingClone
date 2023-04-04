import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from './Shared/Components/not-found/not-found.component';
import { StaysComponent } from './Shared/Components/stays/stays.component';
import { HotelsComponent } from './Hotels/Components/hotels/hotels.component';
import { combineLatest } from 'rxjs';
import { HotelDetailsComponent } from './Hotels/Components/hotel-details/hotel-details.component';
import { AllRoomReservationsComponent } from './Reservations/RoomReservations/Components/all-room-reservations/all-room-reservations.component';
import { AllAttractionReservationsComponent } from './Reservations/AttractionReservations/Components/all-attraction-reservations/all-attraction-reservations.component';
import { CityComponent } from './City/city/city.component';
// import { CityDetailsComponent } from './City/city-details component/city-details.component';
import { CountryComponent } from './Country/country/country.component';
import { CountryDetailsComponent } from './Country/country-details/country-details.component';
import { ContinentComponent } from './Continent/continent/continent.component';
import { ContinenrDetailsComponent } from './Continent/ContinentDetails/continenr-details/continenr-details.component';

const routes: Routes = [
  { path: 'Stays', component: StaysComponent },
  { path: '', redirectTo: '/Stays', pathMatch: 'full' },
  // {path:'CityDetails/:CityID',component:CityDetailsComponent},
  {path:'city',component:CityComponent},
  {path:'CountryDetails/:CountryID',component:CountryDetailsComponent},
  {path:'Country',component:CountryComponent},
  {path:'ContinentDetails/:ContinentID',component:ContinenrDetailsComponent},
  {path:'Continent',component:ContinentComponent},
  { path: 'Room/Reservations', component: AllRoomReservationsComponent },
  { path: 'Attraction/Reservations', component: AllAttractionReservationsComponent },
  { path: 'Hotels', component: HotelsComponent },
  { path: 'HotelDetails/:id', component: HotelDetailsComponent },
  { path: '', redirectTo: '/Room/Reservations', pathMatch: 'full' },
  { path: '**', component: NotFoundComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
