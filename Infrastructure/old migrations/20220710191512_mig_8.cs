using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateWebApi.Persistence.Migrations
{
    public partial class mig_8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DeedStatuses",
                columns: new[] { "Id", "CreatedDate", "IsActive", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(6127), true, "Kat Mülkiyetli", null },
                    { 2L, new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(6132), true, "Kat İrtifaklı", null },
                    { 3L, new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(6134), true, "Arsa", null },
                    { 4L, new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(6135), true, "Tarla", null }
                });

            migrationBuilder.InsertData(
                table: "Fronts",
                columns: new[] { "Id", "CreatedDate", "IsActive", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(6978), true, "Kuzey", null },
                    { 2L, new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(6982), true, "Kuzey Doğu", null },
                    { 3L, new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(6983), true, "Doğu", null },
                    { 4L, new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(6985), true, "Güney Doğu", null },
                    { 5L, new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(6986), true, "Güney", null },
                    { 6L, new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(6987), true, "Güney Batı", null },
                    { 7L, new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(6989), true, "Batı", null },
                    { 8L, new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(6990), true, "Kuzey Batı", null }
                });

            migrationBuilder.InsertData(
                table: "HeatingTypes",
                columns: new[] { "Id", "CreatedDate", "IsActive", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(7660), true, "Doğalgaz Sobalı", null },
                    { 2L, new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(7663), true, "Sobalı", null },
                    { 3L, new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(7665), true, "Yerden Isıtma", null },
                    { 4L, new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(7666), true, "Kombili", null },
                    { 5L, new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(7668), true, "Merkezi Sistem", null },
                    { 6L, new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(7669), true, "FuelOil", null }
                });

            migrationBuilder.InsertData(
                table: "InternetTypes",
                columns: new[] { "Id", "CreatedDate", "IsActive", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(8292), true, "Adsl/Vdsl", null },
                    { 2L, new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(8295), true, "Fiber", null },
                    { 3L, new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(8296), true, "Uydu", null },
                    { 4L, new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(8298), true, "Altyapı Yok", null }
                });

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 548, DateTimeKind.Utc).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 548, DateTimeKind.Utc).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 548, DateTimeKind.Utc).AddTicks(5118));

            migrationBuilder.InsertData(
                table: "PropertyStatuses",
                columns: new[] { "Id", "CreatedDate", "IsActive", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(1620), true, "Satılık", null },
                    { 2L, new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(1625), true, "Kiralık", null },
                    { 3L, new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(1626), true, "Devren Satılık", null },
                    { 4L, new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(1628), true, "Devren Kiralık", null }
                });

            migrationBuilder.InsertData(
                table: "PropertyTypes",
                columns: new[] { "Id", "CreatedDate", "IsActive", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2471), true, "Daire", null },
                    { 2L, new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2475), true, "Residans", null },
                    { 3L, new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2476), true, "Müstakil Ev", null },
                    { 4L, new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2478), true, "Müstakil Bina", null },
                    { 5L, new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2479), true, "Villa", null },
                    { 6L, new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2481), true, "Çiftlik Evi", null },
                    { 7L, new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2482), true, "Yazlık", null },
                    { 8L, new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2483), true, "Büro/Ofis", null },
                    { 9L, new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2485), true, "Depo/Antrepo", null },
                    { 10L, new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2486), true, "Dükkan/Mağaza", null },
                    { 11L, new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2487), true, "Plaza", null },
                    { 12L, new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2489), true, "Palaza Katı", null },
                    { 13L, new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2490), true, "Sağlık Merkezi", null },
                    { 14L, new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2491), true, "Spor Tesisi", null }
                });

            migrationBuilder.InsertData(
                table: "UsingStatuses",
                columns: new[] { "Id", "CreatedDate", "IsActive", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 7, 10, 19, 15, 11, 561, DateTimeKind.Utc).AddTicks(9878), true, "Boş", null },
                    { 2L, new DateTime(2022, 7, 10, 19, 15, 11, 561, DateTimeKind.Utc).AddTicks(9881), true, "Mülk Sahibi", null },
                    { 3L, new DateTime(2022, 7, 10, 19, 15, 11, 561, DateTimeKind.Utc).AddTicks(9883), true, "Kiracılı", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
