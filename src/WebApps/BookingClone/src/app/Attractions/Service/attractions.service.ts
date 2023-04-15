import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/app/environments/environment.development';

@Injectable({
  providedIn: 'root'
})


  export class AttractionsService {


    constructor(private httpClient: HttpClient) {}

    GetAllAtractions(): Observable<any> {
      return this.httpClient.get(`${environment.APIURL}/Attractions`);


    }


    GetAttractionsByCityId(id: any): Observable<any> {
      // alert("Service"+id)
      return this.httpClient.get(`${environment.APIURL}/Attractions/GetAttractionsByCityId?id=${id}`)
    }

    GetAttractionsById(AttractionsId: number): Observable<any> {
      return this.httpClient.get(
        `${environment.APIURL}/Atractions/${AttractionsId}`
      );
    }









  }

