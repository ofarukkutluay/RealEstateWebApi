using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateWebApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_30 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PropertyListingDetailId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "PropertyListingDetailId",
                table: "CustomerOwnedProperties");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PropertyListingDetailId",
                table: "Files",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PropertyListingDetailId",
                table: "CustomerOwnedProperties",
                type: "bigint",
                nullable: true);
        }
    }
}
