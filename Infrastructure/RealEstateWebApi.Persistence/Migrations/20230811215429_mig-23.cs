using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RealEstateWebApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Companies_CompanyId",
                table: "Properties");

            migrationBuilder.AlterColumn<long>(
                name: "CompanyId",
                table: "Properties",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "EntryTypes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "EntrySubTypes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StatusKey",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 938, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 938, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 938, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 938, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Key", "Title" },
                values: new object[] { new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(2860), "TLFN", "Telefon" });

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Key", "Title" },
                values: new object[] { new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(2870), "ZYRT", "Ziyaret" });

            migrationBuilder.InsertData(
                table: "EntrySubTypes",
                columns: new[] { "Id", "CreatedDate", "EntryTypeId", "IsActive", "IsDeleted", "Key", "Title", "UpdatedDate" },
                values: new object[] { 3L, new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(2870), 1L, true, false, "RFRNS", "Referans", null });

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Key", "Title" },
                values: new object[] { new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(3300), "PTNSYL", "Potansiyel" });

            migrationBuilder.InsertData(
                table: "EntryTypes",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "Key", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 2L, new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(3300), true, false, "GRSM", "Görüşme", null },
                    { 3L, new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(3300), true, false, "TKLF", "Teklif", null },
                    { 4L, new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(3300), true, false, "SZLSM", "Sözleşme", null }
                });

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 945, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 945, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 945, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.InsertData(
                table: "EntrySubTypes",
                columns: new[] { "Id", "CreatedDate", "EntryTypeId", "IsActive", "IsDeleted", "Key", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 4L, new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(2870), 2L, true, false, "ZYRT", "Ziyaret", null },
                    { 5L, new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(2870), 2L, true, false, "TLFN", "Telefon", null },
                    { 6L, new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(2870), 2L, true, false, "DOWN", "Potansiyele Düşür", null },
                    { 7L, new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(2870), 3L, true, false, "OTKLF", "Ön Teklif", null },
                    { 8L, new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(2870), 3L, true, false, "RVZ", "Revize", null },
                    { 9L, new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(2870), 3L, true, false, "DOWN", "Kabul Etmedi", null },
                    { 10L, new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(2880), 4L, true, false, "SNLN", "Sunulan", null },
                    { 11L, new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(2880), 4L, true, false, "YPLD", "Yapıldı", null },
                    { 12L, new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(2880), 4L, true, false, "DOWN", "Kabul Etmedi", null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Companies_CompanyId",
                table: "Properties",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Companies_CompanyId",
                table: "Properties");

            migrationBuilder.DeleteData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DropColumn(
                name: "Key",
                table: "EntryTypes");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "EntrySubTypes");

            migrationBuilder.DropColumn(
                name: "StatusKey",
                table: "Customers");

            migrationBuilder.AlterColumn<long>(
                name: "CompanyId",
                table: "Properties",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 386, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 386, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 386, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 386, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Title" },
                values: new object[] { new DateTime(2023, 7, 18, 22, 42, 24, 387, DateTimeKind.Utc).AddTicks(6280), "Ziyaret" });

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Title" },
                values: new object[] { new DateTime(2023, 7, 18, 22, 42, 24, 387, DateTimeKind.Utc).AddTicks(6280), "Telefon" });

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Title" },
                values: new object[] { new DateTime(2023, 7, 18, 22, 42, 24, 387, DateTimeKind.Utc).AddTicks(6690), "Görüşme" });

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 387, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 387, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 387, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 387, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 387, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 387, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 387, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 387, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 387, DateTimeKind.Utc).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 387, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 387, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 387, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 387, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 387, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 387, DateTimeKind.Utc).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 387, DateTimeKind.Utc).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 387, DateTimeKind.Utc).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 387, DateTimeKind.Utc).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 388, DateTimeKind.Utc).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 388, DateTimeKind.Utc).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 388, DateTimeKind.Utc).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 392, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 392, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 392, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 392, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 392, DateTimeKind.Utc).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 392, DateTimeKind.Utc).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 392, DateTimeKind.Utc).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 392, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 392, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 392, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 392, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 392, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 392, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 392, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 392, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 392, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 392, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 392, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 393, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 393, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 393, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Companies_CompanyId",
                table: "Properties",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
