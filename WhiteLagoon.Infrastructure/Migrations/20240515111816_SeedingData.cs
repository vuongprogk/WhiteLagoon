using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WhiteLagoon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MSSV", "Email", "Name" },
                values: new object[,]
                {
                    { "DH52110733", "DH52110733@student.stu.edu.vn", "Nguyễn Sơn Dương" },
                    { "DH52110812", "DH52110812@student.stu.edu.vn", "Trương Thanh Đông" },
                    { "DH52111142", "DH52113526@student.stu.edu.vn", "Nguyễn Huỳnh Thanh Khoa" },
                    { "DH52112120", "dh52112120@student.stu.edu.vn", "Trần Đức Vượng" },
                    { "DH52113526", "DH52113526@student.stu.edu.vn", "Trần Thái Duy" }
                });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "ID", "DateCreate", "DateUpdate", "Description", "ImageUrl", "Name", "Occupancy", "Price", "Sqm" },
                values: new object[,]
                {
                    { 1, null, null, "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://placehold.co/600x400", "Royal Villa", 4, 200.0, 550 },
                    { 2, null, null, "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://placehold.co/600x401", "Premium Pool Villa", 4, 300.0, 550 },
                    { 3, null, null, "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://placehold.co/600x402", "Luxury Pool Villa", 4, 400.0, 750 }
                });

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "Id", "Description", "Name", "VillaId" },
                values: new object[,]
                {
                    { 1, null, "Private Pool", 1 },
                    { 2, null, "Microwave", 1 },
                    { 3, null, "Private Balcony", 1 },
                    { 4, null, "1 king bed and 1 sofa bed", 1 },
                    { 5, null, "Private Plunge Pool", 2 },
                    { 6, null, "Microwave and Mini Refrigerator", 2 },
                    { 7, null, "Private Balcony", 2 },
                    { 8, null, "king bed or 2 double beds", 2 },
                    { 9, null, "Private Pool", 3 },
                    { 10, null, "Jacuzzi", 3 },
                    { 11, null, "Private Balcony", 3 }
                });

            migrationBuilder.InsertData(
                table: "VillaNumbers",
                columns: new[] { "Villa_Number", "SpecialDetails", "VillaId" },
                values: new object[,]
                {
                    { 101, null, 1 },
                    { 102, null, 1 },
                    { 201, null, 2 },
                    { 202, null, 2 },
                    { 301, null, 3 },
                    { 302, null, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MSSV",
                keyValue: "DH52110733");

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MSSV",
                keyValue: "DH52110812");

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MSSV",
                keyValue: "DH52111142");

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MSSV",
                keyValue: "DH52112120");

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MSSV",
                keyValue: "DH52113526");

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
