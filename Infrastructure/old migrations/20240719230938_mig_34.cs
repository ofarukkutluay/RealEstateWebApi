using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateWebApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_34 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PropertyCategoryId",
                table: "CustomerSearchProperties",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PropertyCategoryId",
                table: "CustomerOwnedProperties",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PropertyCategoryId",
                table: "CustomerSearchProperties");

            migrationBuilder.DropColumn(
                name: "PropertyCategoryId",
                table: "CustomerOwnedProperties");
        }
    }
}
