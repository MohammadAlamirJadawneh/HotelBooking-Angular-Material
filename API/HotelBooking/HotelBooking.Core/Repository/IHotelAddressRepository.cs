using HotelBooking.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Core.Repository
{
    public interface IHotelAddressRepository
    {
        List<HotelAddress> GetAllHotelAddress();//stored procedure dbo.GetAllHotelAddress
        void CreateHotelAddress(HotelAddress hotelAddress);//stored procedure dbo.InsertHotelAddress
        void UpdateHotelAddress(HotelAddress hotelAddress);//stored procedure dbo.UpdateHotelAddress
        void DeleteHotelAddressByID(int hotelAddressId);//stored procedure dbo.DeleteHotelAddressByID
        HotelAddress GetHotelAddressByID(int hotelAddressId);//stored procedure dbo.GetHotelAddressByID
    }
}
