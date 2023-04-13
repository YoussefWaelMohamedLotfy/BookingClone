import { Component, OnInit } from '@angular/core';
import { AttractionsService } from '../services/attractions2.service';

@Component({
  selector: 'app-Attractions2',
  templateUrl: './Attractions2.component.html',
  styleUrls: ['./Attractions2.component.css']
})
export class Attractions2Component implements OnInit {
  id:any
AllAtractions:any
  constructor(private services: AttractionsService) { }
  GetAttractionsByCityId(id:any ){
      this.services.GetAttractionsByCityId(id).subscribe(({
          next:res=>{
            this.AllAtractions=res;
            console.log(this.AllAtractions)
          }
      }))
   }

  ngOnInit() {
    this.GetAttractionsByCityId(this.id)
  } 

}
