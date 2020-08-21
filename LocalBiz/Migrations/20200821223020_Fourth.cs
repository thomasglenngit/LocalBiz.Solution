using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBiz.Migrations
{
    public partial class Fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bizs",
                keyColumn: "BizId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bizs",
                keyColumn: "BizId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restos",
                keyColumn: "RestoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restos",
                keyColumn: "RestoId",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Bizs",
                columns: new[] { "BizId", "Address", "Name", "Type", "Url" },
                values: new object[,]
                {
                    { 1, "405 - 3 Wacker Drive, Chicago, IL", "Great Lakes Bank", "Financial - Bank", "info@glbanking.com" },
                    { 3, "#4334 Williams Street, Chicago, IL", "Tip Top Tailor", "Dry Cleaning/Tailor", "charlie@tiptop.com" },
                    { 11, "#334 Bellevue Circle, Chicago, IL", "Crank and Chain", "Transportation - Bicycle Repair", "info@crankandchain.com" }
                });

            migrationBuilder.InsertData(
                table: "Restos",
                columns: new[] { "RestoId", "RAddress", "RName", "RType", "RUrl" },
                values: new object[,]
                {
                    { 2, "#1 Happy Street, Chicago, IL", "Wok With Me", "Restaurant - Chinese", "info@wokwithme.com" },
                    { 4, "#455 Michigan Avenue, Chicago, IL", "Panera", "Restaurant - American", "info@panera.com" },
                    { 10, "#5001 Andretti Blvd, Chicago, IL", "Bowl of Carb", "Restaurant - Italian", "eatme@carbitup.com" },
                    { 12, "#4003 - 3 N. Michigan Avenue, Chicago, IL", "Pho Q", "Restaurant - Vietnamese", "info@phoq.com" }
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
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bizs",
                keyColumn: "BizId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Restos",
                keyColumn: "RestoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restos",
                keyColumn: "RestoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restos",
                keyColumn: "RestoId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Restos",
                keyColumn: "RestoId",
                keyValue: 12);

            migrationBuilder.InsertData(
                table: "Bizs",
                columns: new[] { "BizId", "Address", "Name", "Type", "Url" },
                values: new object[,]
                {
                    { 2, "405 - 3 Wacker Drive, Chicago, IL", "Great Lakes Bank", "Financial - Bank", "info@glbanking.com" },
                    { 4, "#4334 Williams Street, Chicago, IL", "Tip Top Tailor", "Dry Cleaning/Tailor", "charlie@tiptop.com" }
                });

            migrationBuilder.InsertData(
                table: "Restos",
                columns: new[] { "RestoId", "RAddress", "RName", "RType", "RUrl" },
                values: new object[,]
                {
                    { 1, "#1 Happy Street, Chicago, IL", "Wok With Me", "Restaurant - Chinese", "info@wokwithme.com" },
                    { 3, "#455 Michigan Avenue, Chicago, IL", "Panera", "Restaurant - American", "info@panera.com" }
                });
        }
    }
}
