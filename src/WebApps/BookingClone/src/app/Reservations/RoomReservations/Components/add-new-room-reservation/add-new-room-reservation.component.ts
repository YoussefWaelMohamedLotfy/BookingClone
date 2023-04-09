import { Component } from '@angular/core';
import { IAddRoomReservation } from '../../Models/iadd-room-reservation';
import { RoomReservationApiService } from '../../Services/room-reservation-api.service';

@Component({
  selector: 'app-add-new-room-reservation',
  templateUrl: './add-new-room-reservation.component.html',
  styleUrls: ['./add-new-room-reservation.component.css']
})
export class AddNewRoomReservationComponent {
  newRoomReservation: IAddRoomReservation = {} as IAddRoomReservation;

  constructor(private roomReservationAPI: RoomReservationApiService) { }
  
  addNewRoomReservation() {
    this.roomReservationAPI.addNewRoomReservation(this.newRoomReservation).subscribe(response => {
      console.log(response);
    })
  }
}
