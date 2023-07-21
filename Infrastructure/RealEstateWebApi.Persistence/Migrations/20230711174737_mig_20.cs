using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateWebApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Shlink",
                table: "PropertyListingDetails",
                newName: "ListingLink");

            migrationBuilder.RenameColumn(
                name: "ShPhotoLinks",
                table: "PropertyListingDetails",
                newName: "PhotoLinks");

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 628, DateTimeKind.Utc).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 628, DateTimeKind.Utc).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 628, DateTimeKind.Utc).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 628, DateTimeKind.Utc).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 629, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 629, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 629, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 629, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 629, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 629, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 629, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 629, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 629, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 629, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 629, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 629, DateTimeKind.Utc).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 629, DateTimeKind.Utc).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 629, DateTimeKind.Utc).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 629, DateTimeKind.Utc).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 629, DateTimeKind.Utc).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 629, DateTimeKind.Utc).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 629, DateTimeKind.Utc).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 629, DateTimeKind.Utc).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 629, DateTimeKind.Utc).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 629, DateTimeKind.Utc).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 630, DateTimeKind.Utc).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 630, DateTimeKind.Utc).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 630, DateTimeKind.Utc).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 634, DateTimeKind.Utc).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 634, DateTimeKind.Utc).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 634, DateTimeKind.Utc).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 634, DateTimeKind.Utc).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 634, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 634, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 634, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 634, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 634, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 634, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 634, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 634, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 634, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 634, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 634, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 634, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 634, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 634, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 634, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 634, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 11, 17, 47, 37, 634, DateTimeKind.Utc).AddTicks(6640));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhotoLinks",
                table: "PropertyListingDetails",
                newName: "ShPhotoLinks");

            migrationBuilder.RenameColumn(
                name: "ListingLink",
                table: "PropertyListingDetails",
                newName: "Shlink");

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 861, DateTimeKind.Utc).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 861, DateTimeKind.Utc).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 861, DateTimeKind.Utc).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 861, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 863, DateTimeKind.Utc).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 863, DateTimeKind.Utc).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 863, DateTimeKind.Utc).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 863, DateTimeKind.Utc).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 863, DateTimeKind.Utc).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 863, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 863, DateTimeKind.Utc).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 863, DateTimeKind.Utc).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 863, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 863, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 863, DateTimeKind.Utc).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 863, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 863, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 863, DateTimeKind.Utc).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 863, DateTimeKind.Utc).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 863, DateTimeKind.Utc).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 863, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 863, DateTimeKind.Utc).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 863, DateTimeKind.Utc).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 864, DateTimeKind.Utc).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 864, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 864, DateTimeKind.Utc).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 864, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 864, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 871, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 871, DateTimeKind.Utc).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 871, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 871, DateTimeKind.Utc).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 873, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 873, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 873, DateTimeKind.Utc).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 873, DateTimeKind.Utc).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 873, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 873, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 873, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 873, DateTimeKind.Utc).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 873, DateTimeKind.Utc).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 873, DateTimeKind.Utc).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 873, DateTimeKind.Utc).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 873, DateTimeKind.Utc).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 873, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 873, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 874, DateTimeKind.Utc).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 874, DateTimeKind.Utc).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 20, 15, 23, 12, 874, DateTimeKind.Utc).AddTicks(5643));
        }
    }
}
