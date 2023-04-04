import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from './Shared/Components/not-found/not-found.component';
import { StaysComponent } from './Shared/Components/stays/stays.component';
import { CityComponent } from './City/city/city.component';
// import { CityDetailsComponent } from './City/city-details component/city-details.component';
import { CountryComponent } from './Country/country/country.component';
import { CountryDetailsComponent } from './Country/country-details/country-details.component';
import { ContinentComponent } from './Continent/continent/continent.component';
import { ContinenrDetailsComponent } from './Continent/ContinentDetails/continenr-details/continenr-details.component';

const routes: Routes = [
  { path: 'Stays', component: StaysComponent },
  { path: '', redirectTo: '/Stays', pathMatch: 'full' },
  // {path:'CityDetails/:CityID',component:CityDetailsComponent},
  {path:'city',component:CityComponent},
  {path:'CountryDetails/:CountryID',component:CountryDetailsComponent},
  {path:'Country',component:CountryComponent},
  {path:'ContinentDetails/:ContinentID',component:ContinenrDetailsComponent},
  {path:'Continent',component:ContinentComponent},
  { path: '**', component: NotFoundComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
