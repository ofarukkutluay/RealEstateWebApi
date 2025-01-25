using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateWebApi.Persistence.Migrations
{
    public partial class mig_16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PropertyListingDetailId",
                table: "Files",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropertyPhoto_SortIndex",
                table: "Files",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 969, DateTimeKind.Utc).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 969, DateTimeKind.Utc).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 969, DateTimeKind.Utc).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 969, DateTimeKind.Utc).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 972, DateTimeKind.Utc).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 972, DateTimeKind.Utc).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 972, DateTimeKind.Utc).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 972, DateTimeKind.Utc).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 972, DateTimeKind.Utc).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 972, DateTimeKind.Utc).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 972, DateTimeKind.Utc).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 972, DateTimeKind.Utc).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 972, DateTimeKind.Utc).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 972, DateTimeKind.Utc).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 972, DateTimeKind.Utc).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 972, DateTimeKind.Utc).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 972, DateTimeKind.Utc).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 972, DateTimeKind.Utc).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 972, DateTimeKind.Utc).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 972, DateTimeKind.Utc).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 972, DateTimeKind.Utc).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 972, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 972, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 972, DateTimeKind.Utc).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 972, DateTimeKind.Utc).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 973, DateTimeKind.Utc).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 973, DateTimeKind.Utc).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 973, DateTimeKind.Utc).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 982, DateTimeKind.Utc).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 982, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 982, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 982, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 982, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 982, DateTimeKind.Utc).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 982, DateTimeKind.Utc).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 982, DateTimeKind.Utc).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 982, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 982, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 982, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 982, DateTimeKind.Utc).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 982, DateTimeKind.Utc).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 982, DateTimeKind.Utc).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 982, DateTimeKind.Utc).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 982, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 982, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 982, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 983, DateTimeKind.Utc).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 983, DateTimeKind.Utc).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 23, 4, 983, DateTimeKind.Utc).AddTicks(4522));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PropertyListingDetailId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "PropertyPhoto_SortIndex",
                table: "Files");

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 284, DateTimeKind.Utc).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 284, DateTimeKind.Utc).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 284, DateTimeKind.Utc).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 284, DateTimeKind.Utc).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 285, DateTimeKind.Utc).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 285, DateTimeKind.Utc).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 285, DateTimeKind.Utc).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 285, DateTimeKind.Utc).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 285, DateTimeKind.Utc).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 285, DateTimeKind.Utc).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 285, DateTimeKind.Utc).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 285, DateTimeKind.Utc).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 285, DateTimeKind.Utc).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 285, DateTimeKind.Utc).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 285, DateTimeKind.Utc).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 285, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 285, DateTimeKind.Utc).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 285, DateTimeKind.Utc).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 285, DateTimeKind.Utc).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 285, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 285, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 285, DateTimeKind.Utc).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 285, DateTimeKind.Utc).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 285, DateTimeKind.Utc).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 285, DateTimeKind.Utc).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 286, DateTimeKind.Utc).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 286, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 286, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 294, DateTimeKind.Utc).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 294, DateTimeKind.Utc).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 294, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 294, DateTimeKind.Utc).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 294, DateTimeKind.Utc).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 294, DateTimeKind.Utc).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 294, DateTimeKind.Utc).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 294, DateTimeKind.Utc).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 294, DateTimeKind.Utc).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 294, DateTimeKind.Utc).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 294, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 294, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 294, DateTimeKind.Utc).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 294, DateTimeKind.Utc).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 294, DateTimeKind.Utc).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 294, DateTimeKind.Utc).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 294, DateTimeKind.Utc).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 294, DateTimeKind.Utc).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 295, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 295, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 20, 57, 48, 295, DateTimeKind.Utc).AddTicks(4077));
        }
    }
}
