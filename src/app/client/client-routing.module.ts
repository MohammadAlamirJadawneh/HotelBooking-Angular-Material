import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { HotelComponent } from './home/hotel/hotel.component';

const routes: Routes = [
  {
    path: "",
    component: HomeComponent
  }
  , {
    path: "hotel/:search",
    component: HomeComponent
  }
  , {
    path: "hotel/:",
    component: HotelComponent
  }
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ClientRoutingModule {

}
