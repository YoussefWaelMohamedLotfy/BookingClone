import { Component, OnInit } from '@angular/core';
import { ICountry } from '../Models/icountry';
import { ActivatedRoute } from '@angular/router';
import { CountryService } from '../country/Services/country.service';
import { Location } from '@angular/common';
import { CityServiceService } from 'src/app/City/city/Services/city-service.service';
import { ICity } from 'src/app/City/city/Models/icity';

@Component({
  selector: 'app-country-details',
  templateUrl: './country-details.component.html',
  styleUrls: ['./country-details.component.css']
})
export class CountryDetailsComponent implements OnInit {

  currentCountryID: number = 0;
  returnedCity: ICity[]=[];
  Cities: ICity[]| undefined = undefined;

  constructor(
    private activatedRoute: ActivatedRoute,
    private location:Location,
   private cityService: CityServiceService
  ) {}
  ngOnInit(): void {
    this.currentCountryID = this.activatedRoute.snapshot.paramMap.get('CountryID')
    ? Number(this.activatedRoute.snapshot.paramMap.get('CountryID'))
    : 0;


    this.cityService.getcitiesByCountryId(this.currentCountryID).subscribe(data => {
      this.returnedCity = data;


    });

    if (this.returnedCity) {
    this.Cities = this.returnedCity;


    }
    else{
      alert("Cities not found")
      this.location.back();
    }
 }
}


