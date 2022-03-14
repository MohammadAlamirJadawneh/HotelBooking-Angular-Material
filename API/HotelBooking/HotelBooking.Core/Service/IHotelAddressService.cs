using HotelBooking.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Core.Service
{
    public interface IHotelAddressService
    {
        List<HotelAddress> GetAllHotelAddress();//Stored in Repository GetAllHotelAddress
        string CreateHotelAddress(HotelAddress hotelAddress);//Stored in Repository InsertHotelAddress
        string UpdateHotelAddress(HotelAddress hotelAddress);//Stored in Repository UpdateHotelAddress
        string DeleteHotelAddressByID(int hotelAddressId);//Stored in Repository DeleteHotelAddressByID
        HotelAddress GetHotelAddressByID(int HotelAddressId);//Stored in Repository GetHotelAddressByID
    }
}
