using HotelBooking.Core.Data;
using HotelBooking.Core.Repository;
using HotelBooking.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Infra.Service
{
    public class HotelAddressService : IHotelAddressService
    {
        private readonly IHotelAddressRepository iHotelAddressRepository;

        public HotelAddressService(IHotelAddressRepository iHotelAddressRepository)
        {
            this.iHotelAddressRepository = iHotelAddressRepository;
        }
        public string CreateHotelAddress(HotelAddress hotelAddress)
        {
            iHotelAddressRepository.CreateHotelAddress(hotelAddress);
            return "successfully";
        }

        public string DeleteHotelAddressByID(int hotelAddressId)
        {
            iHotelAddressRepository.DeleteHotelAddressByID(hotelAddressId);
            return "Deleted";
        }

        public List<HotelAddress> GetAllHotelAddress()
        {
            return iHotelAddressRepository.GetAllHotelAddress();
        }

        public HotelAddress GetHotelAddressByID(int HotelAddressId)
        {
            return iHotelAddressRepository.GetHotelAddressByID(HotelAddressId);
        }

        public string UpdateHotelAddress(HotelAddress hotelAddress)
        {
            iHotelAddressRepository.UpdateHotelAddress(hotelAddress);

            return "Updated";
        }
    }
}
