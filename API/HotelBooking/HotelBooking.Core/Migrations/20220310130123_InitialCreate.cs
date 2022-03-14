using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelBooking.Core.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    HotelImage = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    HotelPrice = table.Column<double>(type: "float", nullable: false),
                    HotelDiscount = table.Column<double>(type: "float", nullable: false),
                    HotelDescription = table.Column<string>(type: "varchar(5000)", maxLength: 5000, nullable: false),
                    HotelRank = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.HotelId);
                });

            migrationBuilder.CreateTable(
                name: "HotelAddress",
                columns: table => new
                {
                    HotelAddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelAddressCity = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelAddress", x => x.HotelAddressId);
                    table.ForeignKey(
                        name: "FK_HotelAddress_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "HotelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "HotelId", "HotelDescription", "HotelDiscount", "HotelImage", "HotelName", "HotelPrice", "HotelRank" },
                values: new object[,]
                {
                    { 1, "Stay at Mövenpick Hotel Amman to benefit from a great location, excellent food and wonderful Jordanian hospitality.  ", 3.0, "https://cdn.audleytravel.com/700/-/79/154043075198089103191054060164068041221090238072.jpg", "movenpick", 35.0, 6.0 },
                    { 2, "Stay at the Crowne Plaza Hotel Amman to take advantage of the great location, excellent food and wonderful Jordanian hospitality. ", 9.0, "https://pix10.agoda.net/hotelImages/293/293138/293138_14040916380019019069.jpg", "Crowne Plaza", 45.0, 7.0 },
                    { 3, "Thousand Nights is planned to be fully self-sufficient from an infrastructure point of view, providing a diverse range of integrated services that span roads, electrical grids, ", 11.0, "https://imagesawe.s3.amazonaws.com/companies/images/2019/12/thousand_nights_hotel.jpg", "Thousand Nights", 65.0, 7.0 },
                    { 4, "holiday inn is planned to be fully self-sufficient from an infrastructure point of view, providing a diverse range of integrated services that span roads, electrical grids, ", 12.0, "https://www.bridgetravel.com.jo/uploads/0000/15/2019/10/17/gallery-8-file-69.jpg", "holiday inn", 77.0, 7.0 },
                    { 5, "An iconic landmark in bustling Amman, InterContinental Jordan Hotel offers cosmopolitan amenities with a Middle Eastern touch, from light-filled rooms, vibrant furnishings and sweeping architecture to international cuisines, Spa facilities, a selection of beautiful spaces suitable for different occasions, along with magnificent views. Located atop one of the seven hills of Amman, the hotel attracts international clientele from all over the world who enjoy its close proximity to the city center.", 14.0, "https://media.cntraveler.com/photos/5440499858544c134c067b02/16:9/w_2560,c_limit/intercontinental-amman-jordan-exterior-rca-2014.jpg", "intercontinental", 67.0, 4.0 },
                    { 6, "A stay at Corp Amman Hotel places you in the heart of Amman, within a 5-minute drive of The Specialty Hospital and Al Abdali Mall. This 4.5-star hotel is 1.6 mi (2.5 km) from The Boulevard and 2.2 mi (3.6 km) from Amman Citadel. Make yourself at home in one of the 108 air-conditioned rooms featuring minibars and LCD televisions. Complimentary wireless Internet access keeps you connected, and cable programming is available for your entertainment.", 22.0, "https://media-cdn.tripadvisor.com/media/photo-s/10/8f/a3/4e/corp-amman-hotel.jpg", "Corp", 79.0, 6.0 },
                    { 7, "One of our top picks in Amman.This hotel is located in Shmeisani, Amman’s central business district. It features a 24-hour gym, a spa and 3 restaurants. The rooms offer panoramic Amman city views. The modern rooms at the Kempinski Hotel Amman have a seating area, a pillow menu and a marble bathroom with luxury amenities. Some rooms include a separate living area, an LCD TV and access to the Executive Lounge.", 9.0, "http://fstravels.com/cp/pictures/hotels/top/453_Kempinski-Hotel-Amman-Jordan.JPG", "Kempinski", 49.0, 6.0 },
                    { 8, "At the heart of the city, where modern and historic Amman meet, atop one of the city’s most prominent seven hills, Grand Hyatt Amman stands out with its distinctive carved pink stone façade, offering sweeping 360-degree views of the city. From welcoming guests and travelers into our expansive lobby, to not only capturing five-star comfort, but also an abundance of award-winning dining experiences, you will find all of this and more at Grand Hyatt Amman.", 9.0, "https://assets.hyatt.com/content/dam/hyatt/hyattdam/images/2017/08/14/1619/Grand-Hyatt-Amman-P207-Exterior-Night.jpg/Grand-Hyatt-Amman-P207-Exterior-Night.16x9.jpg", "Grand Hyatt Amman", 49.0, 7.0 },
                    { 9, "Toledo Amman Hotel is situated in the heart of Amman, on the edge of the old city center and within walking distance to the new downtown. Toledo Amman Hotel is only few minutes away from major historical and biblical sites, in addition only a two minute walk to the future entertainment center 'Al Abdali Boulevard'.", 9.0, "https://www.toledohotel.jo/content/images/thumbs/0000489_exterior.jpeg", "Toledo Amman Hotel", 49.0, 4.0 }
                });

            migrationBuilder.InsertData(
                table: "HotelAddress",
                columns: new[] { "HotelAddressId", "HotelAddressCity", "HotelId" },
                values: new object[,]
                {
                    { 1, "Amman", 1 },
                    { 20, "Dead Sea", 9 },
                    { 19, "Irbid", 9 },
                    { 18, "Aqaba", 8 },
                    { 17, "Amman", 8 },
                    { 16, "Aqaba", 7 },
                    { 15, "Irbid", 7 },
                    { 14, "Amman", 7 },
                    { 13, "Dead Sea", 6 },
                    { 12, "Irbid", 6 },
                    { 11, "Amman", 6 },
                    { 10, "Aqaba", 5 },
                    { 9, "Amman", 5 },
                    { 6, "Dead Sea", 4 },
                    { 8, "Irbid", 3 },
                    { 7, "Dead Sea", 3 },
                    { 5, "Aqaba", 2 },
                    { 4, "Amman", 2 },
                    { 3, "Dead Sea", 1 },
                    { 2, "Aqaba", 1 },
                    { 21, "Amman", 9 },
                    { 22, "Petra", 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HotelAddress_HotelId",
                table: "HotelAddress",
                column: "HotelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelAddress");

            migrationBuilder.DropTable(
                name: "Hotel");
        }
    }
}
