using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateWebApi.Persistence.Migrations
{
    public partial class mig_18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "PropertyStatusId",
                table: "CustomerOwnedProperties",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "PropertyTypeId",
                table: "CustomerOwnedProperties",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "CustomerOwnedProperties",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<long>(
                name: "DistrictId",
                table: "CustomerOwnedProperties",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CustomerOwnedProperties",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<long>(
                name: "CityId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "PropertyStatusId",
                table: "CustomerOwnedProperties",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "CustomerOwnedProperties",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "DistrictId",
                table: "CustomerOwnedProperties",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CustomerOwnedProperties",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CityId",
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
                value: new DateTime(2023, 1, 15, 21, 58, 36, 319, DateTimeKind.Utc).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 319, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 319, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 319, DateTimeKind.Utc).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 321, DateTimeKind.Utc).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 321, DateTimeKind.Utc).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 321, DateTimeKind.Utc).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 321, DateTimeKind.Utc).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 321, DateTimeKind.Utc).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 321, DateTimeKind.Utc).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 321, DateTimeKind.Utc).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 321, DateTimeKind.Utc).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 321, DateTimeKind.Utc).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 321, DateTimeKind.Utc).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 321, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 321, DateTimeKind.Utc).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 321, DateTimeKind.Utc).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 321, DateTimeKind.Utc).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 321, DateTimeKind.Utc).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 321, DateTimeKind.Utc).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 321, DateTimeKind.Utc).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 321, DateTimeKind.Utc).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 321, DateTimeKind.Utc).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 321, DateTimeKind.Utc).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 321, DateTimeKind.Utc).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 322, DateTimeKind.Utc).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 322, DateTimeKind.Utc).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 322, DateTimeKind.Utc).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 329, DateTimeKind.Utc).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 329, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 329, DateTimeKind.Utc).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 329, DateTimeKind.Utc).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 329, DateTimeKind.Utc).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 329, DateTimeKind.Utc).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 329, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 329, DateTimeKind.Utc).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 329, DateTimeKind.Utc).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 329, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 329, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 329, DateTimeKind.Utc).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 329, DateTimeKind.Utc).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 329, DateTimeKind.Utc).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 329, DateTimeKind.Utc).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 329, DateTimeKind.Utc).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 329, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 329, DateTimeKind.Utc).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 330, DateTimeKind.Utc).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 330, DateTimeKind.Utc).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 15, 21, 58, 36, 330, DateTimeKind.Utc).AddTicks(3851));
        }
    }
}
