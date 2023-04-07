import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IRoomReservation } from '../Models/iroom-reservation';
import { environment } from 'src/app/environments/environment.development';
import { IAddRoomReservation } from '../Models/iadd-room-reservation';
import { IUpdateRoomReservation } from '../Models/iupdate-room-reservation';

@Injectable({
  providedIn: 'root'
})
export class RoomReservationApiService {
  httpHeader = {};

  constructor(private httpClient: HttpClient) {
    this.httpHeader = {
      headers: new HttpHeaders({
        'content-type': 'application/json'
      })
    };
  }

  getPagedRoomReservation(pagesize: Number = 10, pageNumber: Number = 1) {
    
  }

  getRoomReservationById(reservationId: Number): Observable<IRoomReservation> {
    return this.httpClient.get<IRoomReservation>(`${environment.APIURL}/RoomReservations/${reservationId}`);
  }

  addNewRoomReservation(newRoomReservation: IAddRoomReservation): Observable<IRoomReservation> {
    return this.httpClient.post<IRoomReservation>(`${environment.APIURL}/RoomReservations`, JSON.stringify(newRoomReservation), this.httpHeader);
  }

  updateExistingRoomReservation(roomReservation: IUpdateRoomReservation): Observable<IRoomReservation> {
    return this.httpClient.put<IRoomReservation>(`${environment.APIURL}/RoomReservations`, JSON.stringify(roomReservation), this.httpHeader);
  }

  deleteRoomReservation(reservationId: Number): Observable<IRoomReservation> {
    return this.httpClient.delete<IRoomReservation>(`${environment.APIURL}/RoomReservations/${reservationId}`);
  }
}
