using HotelBooking.Core.Data;
using HotelBooking.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelBooking.Infra.Repository
{
    public class HotelAddressRepository : IHotelAddressRepository
    {
        private readonly DataContext dataContext;

        public HotelAddressRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void CreateHotelAddress(HotelAddress hotelAddress)
        {
            dataContext.HotelAddresses.Add(hotelAddress ); /**/
            dataContext.SaveChanges();
        }

        public void DeleteHotelAddressByID(int hotelAddressId)
        {
            dataContext.Remove(dataContext.HotelAddresses.FirstOrDefault(a => a.HotelAddressId == hotelAddressId));
            dataContext.SaveChanges();
        }

        public List<HotelAddress> GetAllHotelAddress()
        {
            var result = dataContext.HotelAddresses.ToList(); /**/
            return result;
        }

        public HotelAddress GetHotelAddressByID(int hotelAddressId)
        {
            HotelAddress hotelAddress = dataContext.HotelAddresses.Where(val => val.HotelAddressId == hotelAddressId).Select(val => new HotelAddress()
            {
                HotelAddressId = val.HotelAddressId,

                HotelAddressCity = val.HotelAddressCity 
            }).SingleOrDefault();

            return hotelAddress;
        }

        public void UpdateHotelAddress(HotelAddress hotelAddress)
        {
            dataContext.HotelAddresses.Update(hotelAddress);
            dataContext.SaveChanges();
        }
    }
}
