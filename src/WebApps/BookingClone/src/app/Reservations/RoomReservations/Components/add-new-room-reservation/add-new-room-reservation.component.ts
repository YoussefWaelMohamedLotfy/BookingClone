import { Component, OnInit } from '@angular/core';
import { IAddRoomReservation } from '../../Models/iadd-room-reservation';
import { RoomReservationApiService } from '../../Services/room-reservation-api.service';
import { render } from 'creditcardpayments/creditCardPayments'

@Component({
  selector: 'app-add-new-room-reservation',
  templateUrl: './add-new-room-reservation.component.html',
  styleUrls: ['./add-new-room-reservation.component.css']
})
export class AddNewRoomReservationComponent implements OnInit {
  newRoomReservation: IAddRoomReservation = {} as IAddRoomReservation;

  constructor(private roomReservationAPI: RoomReservationApiService) { 
    this.newRoomReservation.totalCost = 100;
  }

  ngOnInit(): void {
    render({
      id: "#myPaypalButtons",
      currency: "USD",
      value: this.newRoomReservation.totalCost.toString(),
      onApprove: (details) => {
        this.onPay()
      }
    });
  }

  onPay() {
    console.log("Success");
    this.roomReservationAPI.addNewRoomReservation(this.newRoomReservation).subscribe(response => {
      console.log(response);
    })
  }

  addNewRoomReservation() {
    this.roomReservationAPI.addNewRoomReservation(this.newRoomReservation).subscribe(response => {
      console.log(response);
    })
  }
}

