using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductPriceExchange.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class addnamecolumntocountry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Countries",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Countries");
        }
    }
}
