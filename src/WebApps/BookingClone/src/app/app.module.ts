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
import { CityComponent } from './City/city/city.component';
import { CountryComponent } from './Country/country/country.component';
import { ContinentComponent } from './Continent/continent/continent.component';
import { CountryDetailsComponent } from './Country/country-details/country-details.component';
import { RouterModule } from '@angular/router';


import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CityDetailsComponent } from './City/city-details/city-details.component';
import { NgImageSliderModule } from 'ng-image-slider';
// import { RegisterComponent } from './AUTH/Register/register.component';
import { EgyptCitiesComponent } from './City/egypt-cities/egypt-cities.component';



@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    NotFoundComponent,
    StaysComponent,
    CityComponent,
    CountryComponent,
    ContinentComponent,
    CountryDetailsComponent,
    CityDetailsComponent,
    // RegisterComponent,
    EgyptCitiesComponent,
  ],
  imports: [

    BrowserAnimationsModule,
    RouterModule,
    BrowserModule,
    AppRoutingModule,

    NgImageSliderModule,
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


