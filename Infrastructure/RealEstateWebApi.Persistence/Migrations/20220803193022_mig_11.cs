using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateWebApi.Persistence.Migrations
{
    public partial class mig_11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 362, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 362, DateTimeKind.Utc).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 362, DateTimeKind.Utc).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 362, DateTimeKind.Utc).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 367, DateTimeKind.Utc).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 367, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 367, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 384, DateTimeKind.Utc).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 384, DateTimeKind.Utc).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 384, DateTimeKind.Utc).AddTicks(3334));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 873, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 873, DateTimeKind.Utc).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 873, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 873, DateTimeKind.Utc).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 875, DateTimeKind.Utc).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 875, DateTimeKind.Utc).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 875, DateTimeKind.Utc).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 884, DateTimeKind.Utc).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 884, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 884, DateTimeKind.Utc).AddTicks(5389));
        }
    }
}
