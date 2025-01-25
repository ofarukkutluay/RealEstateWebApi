using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateWebApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_32 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EntryTypeId", "Key", "Title" },
                values: new object[] { 2L, "TAKIP", "Takip" });

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "GRSM", "Görüşme" });

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "DOWN", "İstemiyor" });

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EntryTypeId", "Key", "Title" },
                values: new object[] { 3L, "GIRME", "Girmeden Çalış" });

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "YETKI", "Yetkili" });

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "YETKISIZ", "Yetkisiz" });

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "PDOWN", "Vazgeçti" });

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "GLN", "Gelen" });

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "TAKIP", "Takip" });

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Key",
                value: "IDOWN");

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EntryTypeId", "Key", "Title" },
                values: new object[] { 5L, "STLDI", "Satıldı" });

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "KRLND", "Kiralandı" });

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EntryTypeId", "Key", "Title" },
                values: new object[] { 6L, "TLFN", "Telefon" });

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "GRSM", "Görüşme" });

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "PTNSYL", "Potansiyel" });

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "ILAN", "İlan" });

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "TKLF", "Teklif" });

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "SZLSM", "Sözleşme" });

            migrationBuilder.InsertData(
                table: "EntryTypes",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "Key", "Title", "UpdatedDate" },
                values: new object[] { 6L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, false, "ULSLMD", "Ulaşılamadı", null });

            migrationBuilder.InsertData(
                table: "EntrySubTypes",
                columns: new[] { "Id", "CreatedDate", "EntryTypeId", "IsActive", "IsDeleted", "Key", "Title", "UpdatedDate" },
                values: new object[] { 16L, new DateTime(2000, 12, 31, 22, 0, 0, 0, DateTimeKind.Utc), 6L, true, false, "ZYRT", "Ziyaret", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EntryTypeId", "Key", "Title" },
                values: new object[] { 1L, "RFRNS", "Referans" });

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "ZYRT", "Ziyaret" });

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "TLFN", "Telefon" });

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EntryTypeId", "Key", "Title" },
                values: new object[] { 2L, "DOWN", "Potansiyele Düşür" });

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "OTKLF", "Ön Teklif" });

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "RVZ", "Revize" });

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "DOWN", "Kabul Etmedi" });

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "SNLN", "Sunulan" });

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "YPLD", "Yapıldı" });

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Key",
                value: "GDOWN");

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EntryTypeId", "Key", "Title" },
                values: new object[] { 4L, "PDOWN", "Sözleşme Bitti" });

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "TLFN", "Telefon" });

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EntryTypeId", "Key", "Title" },
                values: new object[] { 5L, "ZYRT", "Ziyaret" });

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "PTNSYL", "Potansiyel" });

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "GRSM", "Görüşme" });

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "TKLF", "Teklif" });

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "SZLSM", "Sözleşme" });

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Key", "Title" },
                values: new object[] { "ULSLMD", "Ulaşılamadı" });
        }
    }
}
