using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateWebApi.Persistence.Migrations
{
    public partial class mig_19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LocationLon",
                table: "PropertyListingDetails",
                type: "text",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LocationLat",
                table: "PropertyListingDetails",
                type: "text",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PropertyTypeId",
                table: "CustomerOwnedProperties",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "LocationLon",
                table: "PropertyListingDetails",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "LocationLat",
                table: "PropertyListingDetails",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PropertyTypeId",
                table: "CustomerOwnedProperties",
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
                value: new DateTime(2023, 1, 15, 22, 12, 30, 7, DateTimeKind.Utc).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 7, DateTimeKind.Utc).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 7, DateTimeKind.Utc).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 7, DateTimeKind.Utc).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 9, DateTimeKind.Utc).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 9, DateTimeKind.Utc).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 9, DateTimeKind.Utc).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 9, DateTimeKind.Utc).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 9, DateTimeKind.Utc).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 9, DateTimeKind.Utc).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 9, DateTimeKind.Utc).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 9, DateTimeKind.Utc).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 9, DateTimeKind.Utc).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 9, DateTimeKind.Utc).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 9, DateTimeKind.Utc).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 9, DateTimeKind.Utc).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 9, DateTimeKind.Utc).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 9, DateTimeKind.Utc).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 9, DateTimeKind.Utc).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 9, DateTimeKind.Utc).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 9, DateTimeKind.Utc).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 9, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 9, DateTimeKind.Utc).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 9, DateTimeKind.Utc).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 9, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 10, DateTimeKind.Utc).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 10, DateTimeKind.Utc).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 10, DateTimeKind.Utc).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 15, DateTimeKind.Utc).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 15, DateTimeKind.Utc).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 15, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 15, DateTimeKind.Utc).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 15, DateTimeKind.Utc).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 15, DateTimeKind.Utc).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 15, DateTimeKind.Utc).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 15, DateTimeKind.Utc).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 15, DateTimeKind.Utc).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 15, DateTimeKind.Utc).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 15, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 15, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 15, DateTimeKind.Utc).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 15, DateTimeKind.Utc).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 15, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 15, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 15, DateTimeKind.Utc).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 15, DateTimeKind.Utc).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 17, DateTimeKind.Utc).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 17, DateTimeKind.Utc).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 22, 12, 30, 17, DateTimeKind.Utc).AddTicks(9585));
        }
    }
}
