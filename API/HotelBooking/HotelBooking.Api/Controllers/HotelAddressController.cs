using HotelBooking.Core.Data;
using HotelBooking.Core.Service;
using HotelBooking.Infra.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBooking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelAddressController : ControllerBase
    {
        private readonly IHotelAddressService iHotelAddressService;
        private readonly ILogger<HotelController> logger;

        public HotelAddressController(IHotelAddressService iHotelAddressService, ILogger<HotelController> logger)
        {
            this.iHotelAddressService = iHotelAddressService;
            this.logger = logger;
        }

        [HttpPost]
        public string CreateHotelAddress([FromBody] HotelAddress hotelAddress)
        {
            return iHotelAddressService.CreateHotelAddress(hotelAddress);
        }

        [HttpGet]
        public ActionResult<IEnumerable<HotelAddress>> GetAllHotelAddress()
        {
            try
            {
                var hotelAddressess = iHotelAddressService.GetAllHotelAddress();
                var hotelAddressService = hotelAddressess.Select(h => new HotelAddress
                {
                    HotelAddressId = h.HotelAddressId,
                    HotelAddressCity = h.HotelAddressCity,
                    HotelId = h.HotelId
                });
                return Ok(hotelAddressService);
            }
            catch (Exception ex)
            {
                logger.LogError($"Failed To Get Hotel Addresses: {ex} ");
                return BadRequest("Faild To Get Hotels Addresses");
            }
        }

        [Route("{HotelAddressId}")]
        [HttpDelete]
        public ActionResult DeleteHotelAddressByID(int HotelAddressId)
        {
            try
            {
                var hotelAddressess = iHotelAddressService.DeleteHotelAddressByID(HotelAddressId);

                if (hotelAddressess != null)
                    return Ok(hotelAddressess);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                logger.LogError($"Failed To Delete This Hotel: {ex} ");
                return BadRequest(ex.Message);
            }
        }

        [Route("{HotelAddressId}")]
        [HttpGet]
        public ActionResult GetHotelAddressById(int hotelAddressId)
        {
            try
            {
                var hotelAddressess = iHotelAddressService.GetHotelAddressByID(hotelAddressId);
                if (hotelAddressess != null)
                    return Ok(hotelAddressess);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                logger.LogError($"Failed to get hotels: {ex} ");
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        public string UpdateHotel([FromBody] HotelAddress hotelAddress)
        {
            return iHotelAddressService.UpdateHotelAddress(hotelAddress);
        }
    }
}
