using HotelBooking.Core.Data;
using HotelBooking.Core.DTO;
using HotelBooking.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Infra.Repository
{
    public class HotelRepository : IHotelRepository
    {
        private readonly DataContext dataContext;


        public HotelRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public IQueryable<SearchHotelByNameOrAddressResponseDTO> GetAllHotels()
        {
            IQueryable<SearchHotelByNameOrAddressResponseDTO> Result = HotelDTO();
            return Result;
        }

        private IQueryable<SearchHotelByNameOrAddressResponseDTO> HotelDTO()
        {
            return from hotel in dataContext.Hotels
                   select new SearchHotelByNameOrAddressResponseDTO()
                   {
                       HotelId = hotel.HotelId,
                       HotelName = hotel.HotelName,
                       HotelImage = hotel.HotelImage,
                       HotelPrice = hotel.HotelPrice,
                       HotelRank = hotel.HotelRank,
                       HotelDiscount = hotel.HotelDiscount,
                       HotelDescription = hotel.HotelDescription

                   };
        }

        public IQueryable<SearchHotelByNameOrAddressResponseDTO> GetHotelByNamesOrAddresses(string hotelAddress)
        {
            IQueryable<SearchHotelByNameOrAddressResponseDTO> Result = HotelByNamesOrAddressesDTO(hotelAddress);

            return Result;
        }

        private IQueryable<SearchHotelByNameOrAddressResponseDTO> HotelByNamesOrAddressesDTO(string searchValue)
        {
            return from hotel in dataContext.Hotels.Where(x => x.HotelName.Contains(searchValue) 
                   || x.HotelAddresses.Where(y => y.HotelAddressCity.Contains(searchValue)).Any())
                   select new SearchHotelByNameOrAddressResponseDTO()
                   {
                       HotelId = hotel.HotelId,
                       HotelName = hotel.HotelName,
                       HotelImage = hotel.HotelImage,
                       HotelPrice = hotel.HotelPrice,
                       HotelRank = hotel.HotelRank,
                       HotelDiscount = hotel.HotelDiscount,
                       HotelDescription = hotel.HotelDescription,
                   };
        }
    }
}
