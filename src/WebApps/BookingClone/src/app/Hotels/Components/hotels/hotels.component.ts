import { Component, OnInit } from '@angular/core';
import { HotelServicesService } from './Services/hotel-services.service';
import { IHotel } from './Models/ihotel';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { hotelImg } from './Models/img'



@Component({
  selector: 'app-hotels',
  templateUrl: './hotels.component.html',
  styleUrls: ['./hotels.component.css']
})
export class HotelsComponent implements OnInit {
  hotelList: any
  pageNumber: number = 1;
  pageSize: number = 10;
  totalItems: number = 0;
  totalPages: number = 100;


  // hotelImg = [
  //   {
  //     id: 1,
  //     imgName: "https://cdn.britannica.com/96/115096-050-5AFDAF5D/Bellagio-Hotel-Casino-Las-Vegas.jpg"
  //   },
  //   {
  //     id: 2,
  //     imgName: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR03l4v5BtW03JxMvJQsCNTOlr7FmBgBrOvZWPbbLznzeOSChEIKPQFmY6QX7zmJdAC7gY&usqp=CAU"
  //   },
  //   {
  //     id: 3,
  //     imgName: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ_grF9sk4c2W8S89wxSsUoFnz7ngOyQXTQFg&usqp=CAU'
  //   },
  //   {
  //     id: 4,
  //     imgName: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSk_8jI5Pv6RQ5HeYf57DZpiQf42au21gH7Xg&usqp=CAU'
  //   },
  //   {
  //     id: 5,
  //     imgName: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTcZrIF2aB6wwZ4Bt2vvx1E0QGzVoCzu2KxwA&usqp=CAU'
  //   },
  //   {
  //     id: 6,
  //     imgName: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTbhc8gBbbeXDThSGr3xGEGsuxFrhwiG_lVmA&usqp=CAU'
  //   },
  //   {
  //     id: 7,
  //     imgName: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTOJTvribeBvVrWRCinz5t9uLrdqsoyMTT2jg&usqp=CAU'
  //   },
  //   {
  //     id: 8,
  //     imgName: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTqpEfAd0xYic2tTcxXAmmBme9TnW9iSdatVg&usqp=CAU'
  //   },
  //   {
  //     id: 9,
  //     imgName: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTBZd9kgR9NOCr70DM-se7tC4Q4GP-KU_jJPw&usqp=CAU'
  //   },
  //   {
  //     id: 10,
  //     imgName: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRLDWOGEG0JP9zkC6VSDmcO3mfvpjYpKt559Q&usqp=CAU'
  //   }



  // ]

  constructor(private hotelApi: HotelServicesService, private router: Router) { }
  showMsg: boolean = false;
  getHotels(type: string) {
    if (type === 'Previous' && this.pageNumber > 1) {
      this.pageNumber--;
    }
    else if (type === 'Next') {
      this.pageNumber++;
    }
    else if (type !== 'First') {
      return
    }

    this.hotelApi.getAllHotel(this.pageNumber, this.pageSize).subscribe(({
      next: res => {
        if (Number(res.pageNumber) > Number(res.totalPages)) {
          this.pageNumber--;
          this.showMsg = true;
          return
        }
        else {
          this.showMsg = false;
        }
        this.totalItems = Number(res.totalPages) * Number(res.pageSize);
        this.hotelList = res.data;

        this.hotelList.map((item: IHotel, ind: number) => {
          let hotel = item;
          // hotel.url = this.hotelImg[ind].imgName;
          hotel.url = hotelImg[ind % hotelImg.length].name;
          return hotel
        });
        console.log(this.hotelList)


      }
    }))
  }



  ngOnInit(): void {

    this.getHotels("First");

  }

  seImgtUrl(hotel: IHotel) {
    this.hotelApi.setImgUrl(hotel.url);

  }

}




