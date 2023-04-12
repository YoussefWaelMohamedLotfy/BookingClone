import { HttpClient,HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { IPagedList } from 'src/app/Shared/Models/Ipaged-list';
import { environment } from 'src/app/environments/environments';
import { IReviews } from '../Models/IReviews';


@Injectable({
  providedIn: 'root'
})
export class ReviewsService {
httpHeader: { headers: any; };

constructor(private http:HttpClient ) {
  this.httpHeader = {
    headers: new HttpHeaders({
      'content-type': 'application/json'
    })
  };
}

currentImgUrl = new BehaviorSubject('');
getImgUrl() {
  if (this.currentImgUrl.value == '') {
    return localStorage.getItem('url') || 'default url';
  }
  return this.currentImgUrl.value;
}
setImgUrl(url: string) {
  this.currentImgUrl.next(url);
  console.log(`url is setting ${url}`);
  localStorage.setItem('url', url);
}
// getAllReviews(){

//   return this.http.get(`${environment.APIURL}/HotelReviews`)
// }


getReviews(pagesize: Number = 10, pageNumber: Number = 1) : Observable<IPagedList<IReviews>> {
  return this.http.get<IPagedList<IReviews>>(`${environment.APIURL}/HotelReviews?pageNumber=${pageNumber}&pageSize=${pagesize}`);
}

}
