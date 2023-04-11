import { Component, Input } from '@angular/core';
import { Iroom } from '../../Models/iroom';

@Component({
  selector: 'app-room-details',
  templateUrl: './room-details.component.html',
  styleUrls: ['./room-details.component.css']
})
export class RoomDetailsComponent {

  @Input()
  roomDetails: any = {};

  constructor() { }
  

}
