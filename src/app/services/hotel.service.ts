import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Hotels } from '../models/hotels/hotels.module';

@Injectable({
  providedIn: 'root'
})
export class HotelService {
  constructor(private http: HttpClient) {
  }
  baseUrl = 'https://localhost:44338/api/Hotel/GetHotelByNamesOrAddresses?searchValue=';
  GetHotelByAddress(search: string): Observable<Hotels[]> {
    return this.http.get<Hotels[]>(this.baseUrl + search);
  }
}