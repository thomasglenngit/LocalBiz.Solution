using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBiz.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Bizs",
                keyColumn: "BizId",
                keyValue: 8);

            migrationBuilder.CreateTable(
                name: "Restos",
                columns: table => new
                {
                    RestoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RName = table.Column<string>(nullable: true),
                    RAddress = table.Column<string>(nullable: true),
                    RType = table.Column<string>(nullable: true),
                    RUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restos", x => x.RestoId);
                });

            migrationBuilder.InsertData(
                table: "Restos",
                columns: new[] { "RestoId", "RAddress", "RName", "RType", "RUrl" },
                values: new object[,]
                {
                    { 1, "#1 Happy Street, Chicago, IL", "Wok With Me", "Restaurant - Chinese", "info@wokwithme.com" },
                    { 3, "#455 Michigan Avenue, Chicago, IL", "Panera", "Restaurant - American", "info@panera.com" },
                    { 6, "#3446 - 55 N. Wacker Drive, Chicago, IL", "Pretzel Choke", "Restaurant - German", "info@pretzelchoke.com" },
                    { 8, "#3 Anderson Road, Chicago, IL", "Green Tongue", "Restaurant - Health Food", "info@greentongue.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restos");

            migrationBuilder.InsertData(
                table: "Bizs",
                columns: new[] { "BizId", "Address", "Name", "Type", "Url" },
                values: new object[,]
                {
                    { 1, "#1 Happy Street, Chicago, IL", "Wok With Me", "Restaurant - Chinese", "info@wokwithme.com" },
                    { 3, "#455 Michigan Avenue, Chicago, IL", "Panera", "Restaurant - American", "info@panera.com" },
                    { 6, "#3446 - 55 N. Wacker Drive, Chicago, IL", "Pretzel Choke", "Restaurant - German", "info@pretzelchoke.com" },
                    { 8, "#3 Anderson Road, Chicago, IL", "Green Tongue", "Restaurant - Health Food", "info@greentongue.com" }
                });
        }
    }
}
