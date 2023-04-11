import { Component, OnInit } from '@angular/core';
import { ReviewsService } from '../services/reviews.service';

@Component({
  selector: 'app-Reviews',
  templateUrl: './Reviews.component.html',
  styleUrls: ['./Reviews.component.css']
})
export class ReviewsComponent implements OnInit {

  reviews:any[]=[]

  constructor(private service:ReviewsService) { }


  ngOnInit() {
    this.getReviews()
  }

getReviews(){
  this.service.getAllReviews().subscribe((result:any) =>{

    this.reviews = result
  })


}





}
