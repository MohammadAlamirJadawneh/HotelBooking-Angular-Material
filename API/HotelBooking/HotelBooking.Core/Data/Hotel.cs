using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HotelBooking.Core.Data
{
    public class Hotel
    { 
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string HotelImage { get; set; }
        public float HotelPrice { get; set; }
        public float HotelDiscount { get; set; }
        public string HotelDescription { get; set; }
        public float HotelRank { get; set; }
        public virtual ICollection<HotelAddress> HotelAddresses { get; set; }
    }
}
