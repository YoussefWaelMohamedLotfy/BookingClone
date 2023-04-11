import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ReviewsService {

constructor(private http:HttpClient ) { }

getAllReviews(){

  return this.http.get('APIURL')
}

}
