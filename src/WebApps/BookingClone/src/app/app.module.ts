import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './Shared/Components/header/header.component';
import { FooterComponent } from './Shared/Components/footer/footer.component';
import { NotFoundComponent } from './Shared/Components/not-found/not-found.component';
import { StaysComponent } from './Shared/Components/stays/stays.component';
import { TranslateLoader, TranslateModule } from '@ngx-translate/core';
import { TranslateHttpLoader } from '@ngx-translate/http-loader';
import { AllRoomReservationsComponent } from './Reservations/RoomReservations/Components/all-room-reservations/all-room-reservations.component';
import { AllAttractionReservationsComponent } from './Reservations/AttractionReservations/Components/all-attraction-reservations/all-attraction-reservations.component';
import { AddNewRoomReservationComponent } from './Reservations/RoomReservations/Components/add-new-room-reservation/add-new-room-reservation.component';
import { AttractionsComponent } from './Attraction/Component/attractions/attractions.component';
import { Attractions2Component } from './Attractions2/component/Attractions2.component';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [	
    AppComponent,
    HeaderComponent,
    FooterComponent,
    NotFoundComponent,
    StaysComponent,
    AttractionsComponent,
    AllRoomReservationsComponent,
    AllAttractionReservationsComponent,
    AddNewRoomReservationComponent,
      Attractions2Component
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule,
    FormsModule,
    HttpClientModule,
    TranslateModule.forRoot({
      defaultLanguage: 'en',
      loader: {
        provide: TranslateLoader,
        useFactory: httpTranslateLoader,
        deps: [HttpClient]
      }
    })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
export function httpTranslateLoader(http: HttpClient) {
  return new TranslateHttpLoader(http);

}


