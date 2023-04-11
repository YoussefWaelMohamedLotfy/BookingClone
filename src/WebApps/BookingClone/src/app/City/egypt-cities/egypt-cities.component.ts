import { Component } from '@angular/core';
import { CityServiceService } from '../city/Services/city-service.service';
import { ActivatedRoute } from '@angular/router';
import { ICity } from '../city/Models/icity';

@Component({
  selector: 'app-egypt-cities',
  templateUrl: './egypt-cities.component.html',
  styleUrls: ['./egypt-cities.component.css']
})
export class EgyptCitiesComponent {
  currentCountryID: number = 22;
  returnedCity: ICity[]=[];





  constructor(

    private cityService: CityServiceService,


  ) {}
  ngOnInit(): void {










      this.cityService.getcitiesByCountryId(this.currentCountryID).subscribe(data => {
        this.returnedCity = data;



    });




  }


}
