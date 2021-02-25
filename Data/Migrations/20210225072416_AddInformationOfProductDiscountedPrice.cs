using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineWatchStore.Data.Migrations
{
    public partial class AddInformationOfProductDiscountedPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DiscountedPrice",
                table: "InformationOfProducts",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountedPrice",
                table: "InformationOfProducts");
        }
    }
}
