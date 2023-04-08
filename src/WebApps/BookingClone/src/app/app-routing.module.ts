import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from './Shared/Components/not-found/not-found.component';
import { StaysComponent } from './Shared/Components/stays/stays.component';
import { AllRoomReservationsComponent } from './Reservations/RoomReservations/Components/all-room-reservations/all-room-reservations.component';

const routes: Routes = [
  { path: 'Stays', component: StaysComponent },
  { path: 'Room/Reservations', component: AllRoomReservationsComponent },
  { path: 'Stays', component: StaysComponent },
  { path: '', redirectTo: '/Room/Reservations', pathMatch: 'full' },
  { path: '**', component: NotFoundComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
