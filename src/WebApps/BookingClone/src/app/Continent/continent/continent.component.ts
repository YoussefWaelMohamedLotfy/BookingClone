import { Component, OnInit } from '@angular/core';
import { IContinent } from '../Models/icontinent';
import { ContinentService } from './Services/continent.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-continent',
  templateUrl: './continent.component.html',
  styleUrls: ['./continent.component.css']
})
export class ContinentComponent implements OnInit {

  selectedContinentID: number = 0;
  ContinentList: IContinent[]=[]

  constructor(private continentService:ContinentService)
   {}


  ngOnInit(): void {

    this. continentService.getAllContinent().subscribe(data => {
    this.ContinentList = data;
      });

  }




  //  ContinentDetails(selectedContinentID: number) {


    // this. continentService.getContinenttByID(this.selectedContinentID).subscribe(data => {
    // this.ContinentList = data;


  // });
}
