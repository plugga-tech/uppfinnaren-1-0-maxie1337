using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace uppfinnaren_1_0_maxie1337.Migrations
{
    /// <inheritdoc />
    public partial class MigrationThree : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "Description", "ImgUrl", "Name" },
                values: new object[,]
                {
                    { 5, "Keramik", "En vacker keramikvas.", "/Images/CVase.jpg", "Vas" },
                    { 6, "Keramik", "En handgjord mugg av lera.", "/Images/CMug.jpg", "Mugg" },
                    { 7, "Smycken", "Ett elegant halsband i silver.", "/Images/CNecklace.jpg", "Halsband" },
                    { 8, "Smycken", "Ett armband med pärlor.", "/Images/CBracelet.jpg", "Armband" },
                    { 9, "Konst", "En vacker tavla med landskap.", "/Images/CPainting.jpg", "Tavla" },
                    { 10, "Konst", "En modern skulptur i sten.", "/Images/CStatue.jpg", "Skulptur" },
                    { 11, "Inredning", "En retro bordslampa.", "/Images/CLamp.jpg", "Lampa" },
                    { 12, "Inredning", "En handknuten matta.", "/Images/CRug.jpg", "Matta" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);
        }
    }
}
