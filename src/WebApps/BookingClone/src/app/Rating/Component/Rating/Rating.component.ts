import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import {NgbRatingModule} from '@ng-bootstrap/ng-bootstrap';
import { IReviews } from '../../Models/IReviews';
import { RateService } from '../../Service/rate.service';
import { IPagedList } from 'src/app/Shared/Models/Ipaged-list';
import { FormsModule } from '@angular/forms';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-Rating',
  standalone: true,
  imports: [NgbRatingModule,CommonModule,FormsModule],

  templateUrl: './Rating.component.html',
  styleUrls: ['./Rating.component.css']
})


export class RatingComponent implements OnInit {
  currentRate1 =0;
  currentRate = 0;
  rates:IReviews[]=[];
  pagesize: Number=0;
  reviews:IReviews[]=[];

  // form= {
  //   "positiveReview": "string",
  //   "negativeReview": "string",
  //   "comfortRate": 0,
  //   "staffRate": 0,
  //   "facilitiesRate": 0,
  //   "valueForMoneyRate": 0,
  //   "cleanlinessRate": 0,
  //   "locationRate": 0,
  //   "hotelID": 0,
  //   "id": 0
  // }

  constructor(private service: RateService , private http:HttpClient) { }

  ngOnInit( ) {

    this.getReviews()
  }



getReviews(){

  this.service.getReviews().subscribe(response => {
    this.reviews = response.data;
    console.log(this.reviews)

  })
}

onReviewCreate(reviews:any){
  this.http.post(`https://localhost:13000/api/HotelReviews`,reviews).subscribe((res) =>{
    console.log(reviews)
    this.service.getReviews().subscribe(response => {
      this.reviews = response.data;
      console.log(this.reviews)

    })
  })
}

}
