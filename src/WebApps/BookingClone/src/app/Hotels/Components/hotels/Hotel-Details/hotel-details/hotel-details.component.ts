import { Component, OnInit } from '@angular/core';
import { HotelServicesService } from '../../Services/hotel-services.service';
import { ActivatedRoute, Router } from '@angular/router';
import { IHotel } from '../../Models/ihotel';
import { Location } from '@angular/common';
import { RoomServiceService } from 'src/app/Rooms/Services/room-service.service';



@Component({
  selector: 'app-hotel-details',
  templateUrl: './hotel-details.component.html',
  styleUrls: ['./hotel-details.component.css']
})
export class HotelDetailsComponent implements OnInit {
  room: any
  currentHotelID: number = 0
  returnedHotel: IHotel | undefined
  hotel: IHotel | undefined
  id: number
  hotelDetail: any
  imgUrl: string = '';
  constructor(private hotelApi: HotelServicesService,
    private router: Router,
    private roomService: RoomServiceService,
    private activatedRoute: ActivatedRoute,
    private location: Location) {
    this.id = activatedRoute.snapshot.params['id']
  }

  getHotelDetails() {
    this.hotelApi.getHotelById(this.id).subscribe(({
      next: res => {
        this.hotelDetail = res
        console.log(this.hotelDetail)
      }


    }))
  }

  getRoomByHotelId(id: number) {
    this.roomService.getRoomByHotelId(this.id).subscribe(({
      next: res => {
        this.room = res
        console.log(this.room)
      },
      error: err => {
        console.log(err.error)
      }
    }))

  }
  ngOnInit(): void {
    this.getHotelDetails()
    this.getRoomByHotelId(this.id);
    setTimeout(() => {
      this.imgUrl = this.hotelApi.getImgUrl();
    }, 100);
    // setTimeout(() => {
    //   this.hotelApi.getImgUrl().subscribe(
    //     (url: string) => {
    //       this.imgUrl = url;
    //       console.log("this.imgUrl");
    //       console.log(this.imgUrl);
    //     }
    //   );
    // }, 100)


  }


}



