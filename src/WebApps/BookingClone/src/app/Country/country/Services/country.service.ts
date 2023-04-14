import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ICountry } from '../../Models/icountry';
import { environment } from '../environment/environment';


@Injectable({
  providedIn: 'root'
})
export class CountryService {


  constructor(private httpClient: HttpClient) {


  }

    getAllCountries(): Observable<ICountry[]> {
      return this.httpClient.get<ICountry[]>(
      `${environment.APIURL}/Countries`

      );

    }

    getcountriesByContinentId(ContinentID: number): Observable<ICountry[]> {
      return this.httpClient.get<ICountry[]>(
        `${environment.APIURL}/Countries?ContinentID=${ContinentID}`
      );
    }

    getContrytByID(CountryID: number): Observable<ICountry> {
      console.log("kkkkkkk",CountryID)
      return this.httpClient.get<ICountry>(
        `${environment.APIURL}/Countries/GetCountryById?id=${CountryID}`
      );
    }
    getContrytByContientID(contientid: number): Observable<ICountry[]> {
      return this.httpClient.get<ICountry[]>(
        `${environment.APIURL}/Countries/${contientid}`
      );
    }



  }
