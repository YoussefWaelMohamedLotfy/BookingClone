import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from './Shared/Components/not-found/not-found.component';
import { StaysComponent } from './Shared/Components/stays/stays.component';
import { ContinentComponent } from './Continent/continent/continent.component';
import { CityDetailsComponent } from './City/city-details/city-details.component';

const routes: Routes = [
  { path: 'Stays', component: StaysComponent },
  { path: '', redirectTo: '/Stays', pathMatch: 'full' },
  {path:'CityDetails/:CountryID',component:CityDetailsComponent},
  {path:'Continent',component:ContinentComponent},
  {path:'Continent/:id',component:ContinentComponent},
  { path: '**', component: NotFoundComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
