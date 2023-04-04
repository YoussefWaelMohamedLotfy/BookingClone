import { Component, OnInit } from '@angular/core';
import { ICity } from '../city/Models/icity';
import { ActivatedRoute } from '@angular/router';
import { CityServiceService } from '../city/Services/city-service.service';
import { Location } from '@angular/common';
@Component({
  selector: 'app-city-details',
  templateUrl: './city-details.component.html',
  styleUrls: ['./city-details.component.css']
})
export class CityDetailsComponent implements OnInit {

  currentCityID: number = 0;
  returnedCity: ICity| undefined=undefined;
  City: ICity | undefined = undefined;

  constructor(
    private activatedRoute: ActivatedRoute,
    private cityService: CityServiceService,
    private location:Location
  ) {}
  ngOnInit(): void {
    this.currentCityID = this.activatedRoute.snapshot.paramMap.get('CityID')
    ? Number(this.activatedRoute.snapshot.paramMap.get('CityID'))
    : 0;


    this.cityService.getCitytByID(this.currentCityID).subscribe(data => {
      this.returnedCity = data;


    });

    if (this.returnedCity) {
    this.City = this.returnedCity;


    }
    else{
      alert("City not found")
      this.location.back();
    }
 }

}
