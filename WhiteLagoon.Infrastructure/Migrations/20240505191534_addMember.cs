using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WhiteLagoon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addMember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MSSV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MSSV);
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
