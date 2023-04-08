import { Component, OnInit } from '@angular/core';
import { HotelServicesService } from '../../Services/hotel-services.service';
import { ActivatedRoute, Router } from '@angular/router';
import { IHotel } from '../../Models/ihotel';
import { Location } from '@angular/common';
import { RoomServiceService } from 'src/app/Rooms/Services/room-service.service';
import { Iroom } from 'src/app/Rooms/Models/iroom';
import { roomImg } from './../../Models/img';



@Component({
  selector: 'app-hotel-details',
  templateUrl: './hotel-details.component.html',
  styleUrls: ['./hotel-details.component.css']
})
export class HotelDetailsComponent implements OnInit {
  rooms: any = [];
  currentHotelID: number = 0
  returnedHotel: IHotel | undefined
  hotel: IHotel | undefined
  id: number
  hotelDetail: any
  imgUrl: string = '';
  roomImgs = roomImg;
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

  getRoomsByHotelId(id: number) {
    console.log(id);

    this.roomService.getRoomsByHotelId(id, 1, 100).subscribe(({
      next: res => {

        this.rooms = res.data?.filter((x: Iroom) => id == x.hotelId);
        console.log("res.data");
        console.log(res.data);
        console.log("this.rooms");
        console.log(this.rooms);

        // this.rooms.push(res);
        // getRoomsByHotelId(id: number) {
        //   this.roomService.getRoomsByHotelId(this.id).subscribe(({
        //     next: res => {
        //       this.rooms = res;
        //       console.log(res);


        this.rooms.map((item: Iroom, ind: number) => {
          let room = item;
          room.url = this.roomImgs[ind].imgName;
          return room
        });
        console.log("this.rooms");
        console.log(this.rooms);
      },
      error: (err: any) => {
        console.log(err.error)
      }
    }))

  }
  ngOnInit(): void {
    this.getHotelDetails()
    this.getRoomsByHotelId(this.id);
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



