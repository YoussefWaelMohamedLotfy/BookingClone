import { Component, OnInit } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';

@Component({
  selector: 'app-StaysHeader',
  templateUrl: './Stays-Header.component.html',
  styleUrls: ['./Stays-Header.component.css']
})
export class StaysHeaderComponent implements OnInit {

  constructor(public translate: TranslateService) { }

  ngOnInit() {
  }

}
