import { Component, OnInit } from '@angular/core';
import { IReviews } from '../Models/IReviews';
import { ReviewsService } from '../services/reviews.service';


@Component({
  selector: 'app-Reviews',
  templateUrl: './Reviews.component.html',
  styleUrls: ['./Reviews.component.css']
})
export class ReviewsComponent implements OnInit {

  reviews:IReviews[]=[];

  constructor(private service:ReviewsService) { }


  ngOnInit() {
    this.getReviews()
  }


getReviews(){

  this.service.getReviews().subscribe(response => {
    this.reviews = response.data;
    console.log(this.reviews)

  })

  

}





}
