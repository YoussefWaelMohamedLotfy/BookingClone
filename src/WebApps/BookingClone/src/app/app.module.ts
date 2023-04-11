import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './Shared/Components/header/header.component';
import { FooterComponent } from './Shared/Components/footer/footer.component';
import { NotFoundComponent } from './Shared/Components/not-found/not-found.component';
import { TranslateLoader, TranslateModule } from '@ngx-translate/core';
import { TranslateHttpLoader } from '@ngx-translate/http-loader';
import { StaysComponent } from './Stays/Stays-Component/Stays.component';
import { ReviewsComponent } from './Reviews/Reviews-Component/Reviews.component';
import { StaysHeaderComponent } from './Stays/Stays-Header-Component/Stays-Header.component';
import { OffersComponent } from './Offers/Component/offers/offers.component';
import { OffersHeaderComponent } from './Offers/Component/offersHeader/offersHeader.component';
import { RouterLink, RouterModule } from '@angular/router';




@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    NotFoundComponent,
    StaysComponent,
    ReviewsComponent,
    StaysHeaderComponent,
    OffersComponent,
    OffersHeaderComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    RouterModule,
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


