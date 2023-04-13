import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-Review-Header',
  templateUrl: './Review-Header.component.html',
  styleUrls: ['./Review-Header.component.css']
})
export class ReviewHeaderComponent implements OnInit {
  reviewCounter:number=0;

  constructor() { }

  ngOnInit() {
  }

  reviewCounterStop:any = setInterval(()=>{
    this.reviewCounter++;
    if(this.reviewCounter == 110000){
      clearInterval(this.reviewCounterStop);
    }
  })


}
