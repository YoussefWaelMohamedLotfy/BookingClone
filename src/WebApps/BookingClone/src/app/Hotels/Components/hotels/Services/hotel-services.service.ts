import { Injectable } from '@angular/core';
import { IHotel } from '../Models/ihotel';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable } from 'rxjs';
import { Environment } from '../environment/environment';
import { Hotel } from '../Models/hotel';

@Injectable({
  providedIn: 'root'
})
export class HotelServicesService {


  constructor(private httpClient: HttpClient) { }


  getAllHotel(): Observable<IHotel[]> {
    return this.httpClient.get<IHotel[]>(`${Environment.APIURL}/api/Hotels?PageNumber=3&PageSize=1`);

  }


  getHotelById(hotelId: number): Observable<IHotel> {
    return this.httpClient.get<IHotel>(`${Environment.APIURL}/Hotels/${hotelId}`)
  }

}
