using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductPriceExchange.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class addcountryfromexchangerate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExchangeRates_Countries_CountryId",
                table: "ExchangeRates");

            migrationBuilder.DropIndex(
                name: "IX_ExchangeRates_CountryId",
                table: "ExchangeRates");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "ExchangeRates");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "ExchangeRates",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExchangeRates_CountryId",
                table: "ExchangeRates",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExchangeRates_Countries_CountryId",
                table: "ExchangeRates",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");
        }
    }
}
