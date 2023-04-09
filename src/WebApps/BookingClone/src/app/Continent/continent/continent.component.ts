import { Component, OnChanges, OnInit, Renderer2, SimpleChanges } from '@angular/core';
import { IContinent } from '../Models/icontinent';
import { ContinentService } from './Services/continent.service';
import { ActivatedRoute, Router } from '@angular/router';
import { CountryService } from 'src/app/Country/country/Services/country.service';
import { ICountry } from 'src/app/Country/Models/icountry';

@Component({
  selector: 'app-continent',
  templateUrl: './continent.component.html',
  styleUrls: ['./continent.component.css']
})
export class ContinentComponent  {

  selectedContinentID: number = 0;
  id:number=0
  ContinentList: IContinent[]=[]
  document: any;
   continentname:string="";

   ListOfCountries: ICountry[] = [];

  constructor(
    private continentService:ContinentService ,
    private _Renderer:Renderer2,
    private countryService: CountryService,
     private router: Router,
     private activRoute:ActivatedRoute
    )
   {


   }







  ngOnInit(): void {
    this. continentService.getAllContinent().subscribe(data => {
    this.ContinentList = data;
      });

this.activRoute.paramMap.subscribe(x=>{
  this.id=Number(x.get('id'))

  if(this.id!=0 || !this.id){
    this.countryService.getContrytByContientID(this.id).subscribe(d=>{
    this.ListOfCountries=d;

    })
    }else{

      this.countryService.getAllCountries().subscribe(data1=>{


       this.ListOfCountries=data1;



     })
    }
})






  }

  getItems(id:any, e:any) {
    this.selectedContinentID = id;
     let activeDivs = this.document.getElementsByClassName('category-select');
     let activeArray = [].slice.call(activeDivs);
     for(let i = 0; i < activeArray.length; i++) {
       let element:any = activeArray[i];
        this._Renderer.removeClass(element, 'active');
     }
      this._Renderer.addClass(e.target , 'active');
  };



  CountryDetails(CountryID: number) {
    this.router.navigate(['CityDetails', CountryID]);
  }


  getCountryByContientId(iD:number){

    this.router.navigate(['Continent/',iD])

  }
}
