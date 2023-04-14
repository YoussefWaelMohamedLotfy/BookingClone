import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/app/City/city/environment/environment';
import { IContinent } from '../../Models/icontinent';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ContinentService {


  constructor(private httpClient: HttpClient) {}

  getAllContinent(): Observable<IContinent[]> {
    return this.httpClient.get<IContinent[]>("https://localhost:13000/api/Continents");

  }


  getContinenttByID(ContinentsID: number): Observable<IContinent> {
    return this.httpClient.get<IContinent>(
      `${environment.APIURL}/Continents/${ContinentsID}`
    );
  }









}
