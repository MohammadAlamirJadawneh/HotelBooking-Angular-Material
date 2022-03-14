using HotelBooking.Core.Data;
using HotelBooking.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Core.Repository
{
    public interface IHotelRepository
    {
        /*
        List<Hotel> GetAllHotel();
  
        List<Hotel> GetHotelByAddress(string hotelAddress);
        */
        IQueryable<SearchHotelByNameOrAddressResponseDTO> GetAllHotels();
        IQueryable<SearchHotelByNameOrAddressResponseDTO> GetHotelByNamesOrAddresses(string searchValue);
 
    }
}
