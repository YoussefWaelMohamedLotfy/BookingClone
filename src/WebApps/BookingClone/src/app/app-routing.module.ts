import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from './Shared/Components/not-found/not-found.component';
import { StaysComponent } from './Shared/Components/stays/stays.component';
import { AttractionsComponent } from './Attraction/Component/attractions/attractions.component';

import { AllRoomReservationsComponent } from './Reservations/RoomReservations/Components/all-room-reservations/all-room-reservations.component';
import { AllAttractionReservationsComponent } from './Reservations/AttractionReservations/Components/all-attraction-reservations/all-attraction-reservations.component';
import { Attractions2Component } from './Attractions2/component/Attractions2.component';

const routes: Routes = [
  { path: 'attractions2', component: Attractions2Component },
  { path: 'attractions', component: AttractionsComponent },
  { path: 'Room/Reservations', component: AllRoomReservationsComponent },
  { path: 'Attraction/Reservations', component: AllAttractionReservationsComponent },
  { path: 'Stays', component: StaysComponent },
  { path: '', redirectTo: '/Room/Reservations', pathMatch: 'full' },
  { path: '**', component: NotFoundComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
