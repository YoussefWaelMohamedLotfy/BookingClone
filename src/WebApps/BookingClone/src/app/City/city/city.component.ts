import { Component, OnChanges, OnInit } from '@angular/core';
import { ICity } from './Models/icity';
import { CityServiceService } from './Services/city-service.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-city',
  templateUrl: './city.component.html',
  styleUrls: ['./city.component.css']
})
export class CityComponent implements OnInit {
  date1: Date = new Date();
  ListOfCities: ICity[] = [];
  receivedCountryID: number = 0;

  constructor(private cityServiceService: CityServiceService,  private router: Router)

   {

   }


   ngOnInit(): void {
    if(this.receivedCountryID==0){

      this.cityServiceService.getAllCities().subscribe(data1=>{
        // console.log('dddddddddddddd',data1)
        this.ListOfCities=data1;


      })
    }
    else{
    this.cityServiceService.getcitiesByCountryId(this.receivedCountryID).subscribe(data => {
      this.ListOfCities = data;


    });



  }
}

 CityDetails(CityID: number) {
    this.router.navigate(['CityDetails', CityID]);
  }

}

