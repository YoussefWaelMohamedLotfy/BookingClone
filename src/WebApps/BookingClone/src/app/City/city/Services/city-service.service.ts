import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ICity } from '../Models/icity';
import { Observable } from 'rxjs';
import { environment } from '../environment/environment';

@Injectable({
  providedIn: 'root'
})
export class CityServiceService {
  constructor(private httpClient: HttpClient) {}

  getAllCities(): Observable<ICity[]> {
    return this.httpClient.get<ICity[]>(`${environment.APIURL}/cities`);


  }





  getcitiesByCountryId(id: number): Observable<any> {
    // alert("Service"+id)
    return this.httpClient.get(`${environment.APIURL}/cities/GetCityByCountryId?id=${id}`)
  }

  getCitytByID(CityID: number): Observable<ICity> {
    return this.httpClient.get<ICity>(
      `${environment.APIURL}/cities/${CityID}`
    );
  }









}
