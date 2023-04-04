import { Component, OnInit } from '@angular/core';
import { HotelServicesService } from './Services/hotel-services.service';
import { IHotel } from './Models/ihotel';
import { Router } from '@angular/router';
import { Hotel } from './Models/hotel';

@Component({
  selector: 'app-hotels',
  templateUrl: './hotels.component.html',
  styleUrls: ['./hotels.component.css']
})
export class HotelsComponent implements OnInit {
  HotelList: IHotel[] = []



  constructor(private hotelApi: HotelServicesService, private router: Router) {



  }

  ngOnInit(): void {

    this.hotelApi.getAllHotel().subscribe(data => { this.HotelList = data })



  }


}




