using HotelBooking.Core.Data;
using HotelBooking.Core.DTO;
using HotelBooking.Core.Repository;
using HotelBooking.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelBooking.Infra.Service
{
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository iHotelRepository;

        public HotelService(IHotelRepository iHotelRepository)
        {
            this.iHotelRepository = iHotelRepository;
        }
        public IQueryable<SearchHotelByNameOrAddressResponseDTO> GetAllHotels()
        {
            return iHotelRepository.GetAllHotels();
        }
        public IQueryable<SearchHotelByNameOrAddressResponseDTO> GetHotelByNamesOrAddresses(string searchValue)
        {
            return iHotelRepository.GetHotelByNamesOrAddresses(searchValue);
        }
       
        
    }
}
