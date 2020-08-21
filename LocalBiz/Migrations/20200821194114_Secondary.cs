using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBiz.Migrations
{
    public partial class Secondary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bizs",
                columns: new[] { "BizId", "Address", "Name", "Type", "Url" },
                values: new object[,]
                {
                    { 1, "#1 Happy Street, Chicago, IL", "Wok With Me", "Restaurant - Chinese", "info@wokwithme.com" },
                    { 2, "405 - 3 Wacker Drive, Chicago, IL", "Great Lakes Bank", "Financial - Bank", "info@glbanking.com" },
                    { 3, "#455 Michigan Avenue, Chicago, IL", "Panera", "Restaurant - American", "info@panera.com" },
                    { 4, "#4334 Williams Street, Chicago, IL", "Tip Top Tailor", "Dry Cleaning/Tailor", "charlie@tiptop.com" },
                    { 5, "#253 Jackson Avenue, Chicago, IL", "Euro Cars", "Auto Mechanic", "info@eurocars.com" },
                    { 6, "#3446 - 55 N. Wacker Drive, Chicago, IL", "Pretzel Choke", "Restaurant - German", "info@pretzelchoke.com" },
                    { 7, "#478 Cander Avenue, Chicago, IL", "Trip and Slide", "Recreational - Roller Rink", "info@tripandslide.com" },
                    { 8, "#3 Anderson Road, Chicago, IL", "Green Tongue", "Restaurant - Health Food", "info@greentongue.com" },
                    { 9, "#4446 - 305 Jackson Avenue, Chicago, IL", "Tax Grind", "Financial - Tax Preparation", "info@taxgrind.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bizs",
                keyColumn: "BizId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bizs",
                keyColumn: "BizId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bizs",
                keyColumn: "BizId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bizs",
                keyColumn: "BizId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bizs",
                keyColumn: "BizId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Bizs",
                keyColumn: "BizId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Bizs",
                keyColumn: "BizId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Bizs",
                keyColumn: "BizId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Bizs",
                keyColumn: "BizId",
                keyValue: 9);
        }
    }
}
