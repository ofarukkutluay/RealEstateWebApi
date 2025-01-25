using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateWebApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_27 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhotoLinks",
                table: "OuterPropertyListings",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string[]>(
                name: "PhotoLinks",
                table: "OuterPropertyListings",
                type: "text[]",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
