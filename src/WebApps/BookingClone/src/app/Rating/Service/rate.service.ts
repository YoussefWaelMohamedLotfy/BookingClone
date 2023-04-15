import { HttpClient,HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { IPagedList } from 'src/app/Shared/Models/Ipaged-list';
import { environment } from 'src/app/environments/environments';
import { IReviews } from '../Models/IReviews';

@Injectable({
  providedIn: 'root'
})
export class RateService {

constructor(private http:HttpClient) { }

model= {
  "positiveReview": "string",
  "negativeReview": "string",
  "comfortRate": 0,
  "staffRate": 0,
  "facilitiesRate": 0,
  "valueForMoneyRate": 0,
  "cleanlinessRate": 0,
  "locationRate": 0,
  "hotelID": 0,
  "id": 0
}

CreateReviews(model:any){
  return this.http.post<IPagedList<IReviews>>(`${environment.APIURL}/HotelReviews`,model);
}

getReviews(pagesize: Number = 10, pageNumber: Number = 1) : Observable<IPagedList<IReviews>> {
  return this.http.get<IPagedList<IReviews>>(`${environment.APIURL}/HotelReviews?pageNumber=${pageNumber}&pageSize=${pagesize}`);
}




}
