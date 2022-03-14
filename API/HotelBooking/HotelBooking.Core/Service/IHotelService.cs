using HotelBooking.Core.Data;
using HotelBooking.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelBooking.Core.Service
{
    public interface IHotelService
    {
        IQueryable<SearchHotelByNameOrAddressResponseDTO> GetAllHotels();
        IQueryable<SearchHotelByNameOrAddressResponseDTO> GetHotelByNamesOrAddresses(string searchValue);
    }
}
