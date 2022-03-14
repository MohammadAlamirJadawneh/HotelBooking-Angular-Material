
namespace HotelBooking.Core.Data
{
    public class HotelAddress
    {
        public int HotelAddressId { get; set; } 
        public string HotelAddressCity { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
    }
}
