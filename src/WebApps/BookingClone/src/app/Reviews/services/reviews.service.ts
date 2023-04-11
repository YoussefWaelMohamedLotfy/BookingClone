import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { environment } from 'src/app/environments/environments';


@Injectable({
  providedIn: 'root'
})
export class ReviewsService {

constructor(private http:HttpClient ) { }

getAllReviews(){

  return this.http.get(`${environment.APIURL}/HotelReviews`)
}

}
