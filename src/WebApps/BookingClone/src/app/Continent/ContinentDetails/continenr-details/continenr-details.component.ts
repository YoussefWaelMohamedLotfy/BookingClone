import { Component, OnInit } from '@angular/core';
import { IContinent } from '../../Models/icontinent';
import { ActivatedRoute } from '@angular/router';
import { ContinentService } from '../../continent/Services/continent.service';
import { Location } from '@angular/common';
@Component({
  selector: 'app-continenr-details',
  templateUrl: './continenr-details.component.html',
  styleUrls: ['./continenr-details.component.css']
})
export class ContinenrDetailsComponent  implements OnInit{

    currentContinentID: number = 0;
    returnedContinent: IContinent| undefined=undefined;
    Continent: IContinent | undefined = undefined;

    constructor(
      private activatedRoute: ActivatedRoute,
      private continentService: ContinentService,
      private location:Location
    ) {}
    ngOnInit(): void {
      this.currentContinentID = this.activatedRoute.snapshot.paramMap.get('ContinentID')
      ? Number(this.activatedRoute.snapshot.paramMap.get('ContinentID'))
      : 0;


      this.continentService.getContinenttByID(this.currentContinentID).subscribe(data => {
        this.returnedContinent = data;


      });

      if (this.returnedContinent) {
      this.Continent = this.returnedContinent;


      }
      else{
        alert("Continent not found")
        this.location.back();
      }
   }




}
