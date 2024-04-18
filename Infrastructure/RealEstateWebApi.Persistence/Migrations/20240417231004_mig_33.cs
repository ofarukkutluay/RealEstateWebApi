using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateWebApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_33 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Entries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "ULSLMD", "Ulaşılamadı" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Entries",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "TLFN", "Telefon" });

            migrationBuilder.InsertData(
                table: "EntrySubTypes",
                columns: new[] { "Id", "CreatedDate", "EntryTypeId", "IsActive", "IsDeleted", "Key", "Title", "UpdatedDate" },
                values: new object[] { 16L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), 6L, true, false, "ZYRT", "Ziyaret", null });
        }
    }
}
