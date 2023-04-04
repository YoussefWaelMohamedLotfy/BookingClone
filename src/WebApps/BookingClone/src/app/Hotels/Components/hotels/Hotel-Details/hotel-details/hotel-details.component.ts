import { Component } from '@angular/core';
import { HotelServicesService } from '../../Services/hotel-services.service';
import { ActivatedRoute, Router } from '@angular/router';
import { IHotel } from '../../Models/ihotel';
import { Location } from '@angular/common';

@Component({
  selector: 'app-hotel-details',
  templateUrl: './hotel-details.component.html',
  styleUrls: ['./hotel-details.component.css']
})
export class HotelDetailsComponent {
  sub: any
  currentHotelID: number = 0
  returnedHotel: IHotel | undefined
  hotel: IHotel | undefined
  constructor(private hotelApi: HotelServicesService, private router: Router, private activatedRoute: ActivatedRoute, private location: Location) { }

  ngOnInit(): void {
    this.currentHotelID = (this.activatedRoute.snapshot.paramMap.get('pid')) ? Number(this.activatedRoute.snapshot.paramMap.get('pid')) : 0


    this.hotelApi.getHotelById(this.currentHotelID).subscribe(data => {
      this.returnedHotel = data;


    });

    if (this.returnedHotel) {
      this.hotel = this.returnedHotel;


    }
    else {
      alert("Hotel not found")
      this.location.back();
    }
  }


}
