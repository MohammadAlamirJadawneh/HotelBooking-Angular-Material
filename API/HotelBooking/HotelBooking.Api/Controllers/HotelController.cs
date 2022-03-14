using HotelBooking.Core.Data;
using HotelBooking.Core.DTO;
using HotelBooking.Core.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelBooking.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService iHotelService;
        private readonly ILogger<HotelController> logger;
        public HotelController(IHotelService iHotelService, ILogger<HotelController> logger)
        {
            this.iHotelService = iHotelService;
            this.logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<SearchHotelByNameOrAddressResponseDTO>> GetHotelByNamesOrAddresses(string searchValue )
        {
            try
            {
                if (string.IsNullOrEmpty(searchValue))
                {
                    var hotels = iHotelService.GetAllHotels();
                    IEnumerable<SearchHotelByNameOrAddressResponseDTO> hotelsDTO = ConvertToDTO(hotels);
                    return Ok(hotelsDTO);
                }
                else
                {
                    var hotels = iHotelService.GetHotelByNamesOrAddresses(searchValue);
                    IEnumerable<SearchHotelByNameOrAddressResponseDTO> hotelsDTO = ConvertToDTO(hotels);
                    return Ok(hotelsDTO);
                }
            }
            catch (Exception ex)
            {
                logger.LogError($"Failed to get hotels: {ex} ");
                return BadRequest("Faild to get Hotels");
            }
        }

        private IEnumerable<SearchHotelByNameOrAddressResponseDTO> ConvertToDTO(IQueryable<SearchHotelByNameOrAddressResponseDTO> hotels)
        {
            return hotels.Select(h => new SearchHotelByNameOrAddressResponseDTO
            {
                HotelId = h.HotelId,
                HotelName = h.HotelName,
                HotelImage = h.HotelImage,
                HotelPrice = h.HotelPrice,
                HotelDiscount = h.HotelDiscount,
                HotelDescription = h.HotelDescription,
                HotelRank = h.HotelRank
            });
        }


    }
}
