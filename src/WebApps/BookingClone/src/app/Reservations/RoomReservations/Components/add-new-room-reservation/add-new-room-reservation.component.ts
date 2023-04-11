import { Component, OnInit } from '@angular/core';
import { IAddRoomReservation } from '../../Models/iadd-room-reservation';
import { RoomReservationApiService } from '../../Services/room-reservation-api.service';
import { IPayPalConfig, ICreateOrderRequest } from 'ngx-paypal';

@Component({
  selector: 'app-add-new-room-reservation',
  templateUrl: './add-new-room-reservation.component.html',
  styleUrls: ['./add-new-room-reservation.component.css']
})
export class AddNewRoomReservationComponent implements OnInit {
  public payPalConfig?: IPayPalConfig;
  public showSuccess: boolean = false;

  newRoomReservation: IAddRoomReservation = {} as IAddRoomReservation;

  constructor(private roomReservationAPI: RoomReservationApiService) {
    this.newRoomReservation.totalCost = 100;
  }

  ngOnInit(): void {
    this.initConfig();
  }

  private initConfig(): void {
    this.payPalConfig = {
      currency: 'USD',
      clientId: 'AZGk4DsZ_0XmLoge17GeZNmrSGmy2eVoJ_hCN7csqfsOuNUGLwGog2p4Og-Qp9_7sLcxmXETjV5TzANA',
      createOrderOnClient: (data) => <ICreateOrderRequest>{
        intent: 'CAPTURE',
        purchase_units: [
          {
            amount: {
              currency_code: 'USD',
              value: this.newRoomReservation.totalCost.toString(),
              breakdown: {
                item_total: {
                  currency_code: 'USD',
                  value: this.newRoomReservation.totalCost.toString()
                }
              }
            },
            items: [
              {
                name: 'Room Reservation',
                quantity: '1',
                category: 'DIGITAL_GOODS',
                unit_amount: {
                  currency_code: 'USD',
                  value: this.newRoomReservation.totalCost.toString(),
                },
              }
            ]
          }
        ]
      },
      advanced: {
        commit: 'true'
      },
      style: {
        label: 'paypal',
        layout: 'vertical'
      },
      onApprove: (data, actions) => {
        console.log('onApprove - transaction was approved, but not authorized', data, actions);
        this.addNewRoomReservation();
        actions.order.get().then((details: any) => {
          console.log('onApprove - you can get full order details inside onApprove: ', details);
        });
      },
      onClientAuthorization: (data) => {
        console.log('onClientAuthorization - you should probably inform your server about completed transaction at this point', data);
        this.showSuccess = true;
      },
      onCancel: (data, actions) => {
        console.log('OnCancel', data, actions);
      },
      onError: err => {
        console.log('OnError', err);
      },
      onClick: (data, actions) => {
        console.log('onClick', data, actions);
      },
    };
  }

  addNewRoomReservation() {
    this.roomReservationAPI.addNewRoomReservation(this.newRoomReservation).subscribe(response => {
      console.log(response);
    })
  }
}

