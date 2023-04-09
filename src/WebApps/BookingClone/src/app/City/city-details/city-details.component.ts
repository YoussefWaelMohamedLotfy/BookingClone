import { Component, OnInit } from '@angular/core';
import { ICity } from '../city/Models/icity';
import { ActivatedRoute } from '@angular/router';
import { CityServiceService } from '../city/Services/city-service.service';
import { Location } from '@angular/common';
import { ICountry } from 'src/app/Country/Models/icountry';
import { CountryService } from 'src/app/Country/country/Services/country.service';
@Component({
  selector: 'app-city-details',
  templateUrl: './city-details.component.html',
  styleUrls: ['./city-details.component.css']
})
export class CityDetailsComponent implements OnInit {

  currentCountryID: number = 0;
  returnedCity: ICity[]=[];
  City: ICity []=[];


  findname:ICountry | undefined


  constructor(
    private activatedRoute: ActivatedRoute,
    private cityService: CityServiceService,
    private location:Location,
    private countryService : CountryService,
  ) {}
  ngOnInit(): void {







this.activatedRoute.paramMap.subscribe(a=> {

this.currentCountryID  =Number(a.get('CountryID'))  ;
this.getfindname();

})


      this.cityService.getcitiesByCountryId(this.currentCountryID).subscribe(data => {
        this.returnedCity = data;

      if (this.returnedCity) {
      this.City = this.returnedCity;


      }
      else{
        alert("City not found")
        this.location.back();
      }


    });




  }

  getfindname():void{
    console.log(this.currentCountryID)
    this.countryService.getContrytByID(this.currentCountryID).subscribe(d=>{
      this.findname=d;


    })


  }
}
