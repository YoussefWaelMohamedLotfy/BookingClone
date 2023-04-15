import { Component, OnInit } from '@angular/core';
import { AttractionsService } from '../Service/attractions.service';

@Component({
  selector: 'app-attractions',
  templateUrl: './attractions.component.html',
  styleUrls: ['./attractions.component.css']
})
export class AttractionsComponent implements OnInit {


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


