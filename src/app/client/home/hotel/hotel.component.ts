import { Component, Input } from '@angular/core';
import { HotelService } from 'src/app/services/hotel.service';

@Component({
  selector: 'app-hotel',
  templateUrl: './hotel.component.html',
  styleUrls: ['./hotel.component.css']
})
export class HotelComponent {
  _SearchValue: string = '';
  get SearchValue(): string {
    return this._SearchValue;
  }
  @Input() set SearchValue(value: string) {
    this._SearchValue = value;
    this.GetHotels(this._SearchValue);
  }
  hotels: any[];
  constructor(public hotelService: HotelService) {
    this.hotels = [];
  }

  async GetHotels(search: string = ''): Promise<void> {
    this.hotelService.GetHotelByAddress(search).subscribe((item) => {
      this.hotels = item;
      console.log('this.hotels', this.hotels);
    });
  }
}