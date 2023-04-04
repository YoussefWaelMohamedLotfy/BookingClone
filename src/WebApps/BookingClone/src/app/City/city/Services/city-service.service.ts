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
    return this.httpClient.get<ICity[]>("https://localhost:13000/api/Cities");
   // return this.httpClient.get<ICity[]>("https://localhost:13000/v1/api/GetAllCities");

  }

  getcitiesByCountryId(CountryID: number): Observable<ICity[]> {
    return this.httpClient.get<ICity[]>(
      `${environment.APIURL}/cities?CountryID=${CountryID}`
    );
  }

  getCitytByID(CityID: number): Observable<ICity> {
    return this.httpClient.get<ICity>(
      `${environment.APIURL}/cities/${CityID}`
    );
  }









}
