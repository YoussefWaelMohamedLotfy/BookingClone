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
export class CountryDetailsComponent  {


}
