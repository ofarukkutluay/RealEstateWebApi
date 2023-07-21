using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateWebApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CustomerId",
                table: "Reminder",
                type: "bigint",
                nullable: true);

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
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 387, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 387, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 22, 42, 24, 387, DateTimeKind.Utc).AddTicks(6690));

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

            migrationBuilder.CreateIndex(
                name: "IX_Reminder_CustomerId",
                table: "Reminder",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reminder_Customers_CustomerId",
                table: "Reminder",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reminder_Customers_CustomerId",
                table: "Reminder");

            migrationBuilder.DropIndex(
                name: "IX_Reminder_CustomerId",
                table: "Reminder");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Reminder");

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 467, DateTimeKind.Utc).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 467, DateTimeKind.Utc).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 467, DateTimeKind.Utc).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 467, DateTimeKind.Utc).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 468, DateTimeKind.Utc).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 468, DateTimeKind.Utc).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 468, DateTimeKind.Utc).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 468, DateTimeKind.Utc).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 468, DateTimeKind.Utc).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 468, DateTimeKind.Utc).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 468, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 468, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 468, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 468, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 468, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 468, DateTimeKind.Utc).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 468, DateTimeKind.Utc).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 468, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 468, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 468, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 468, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 468, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 468, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 468, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 468, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 469, DateTimeKind.Utc).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 469, DateTimeKind.Utc).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 469, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 473, DateTimeKind.Utc).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 473, DateTimeKind.Utc).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 473, DateTimeKind.Utc).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 473, DateTimeKind.Utc).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 473, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 473, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 473, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 473, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 473, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 473, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 473, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 473, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 473, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 473, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 473, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 473, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 473, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 473, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 474, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 474, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 18, 21, 49, 12, 474, DateTimeKind.Utc).AddTicks(5960));
        }
    }
}
