import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Environment } from 'src/app/Hotels/Components/hotels/environment/environment';

@Injectable({
  providedIn: 'root'
})
export class RoomServiceService {

  constructor(private httpClient: HttpClient) { }

  getRoomsByHotelId(id: number, pageNumber: number, pageSize: number): Observable<any> {
    // return this.httpClient.get(`${Environment.APIURL}/api/Rooms/${id}`)
    return this.httpClient.get(`${Environment.APIURL}/api/Rooms?PageNumber=${pageNumber}&PageSize=${pageSize}`)
  }
}
