using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RealEstateWebApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_21 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reminder",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ReminderDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EntryId = table.Column<long>(type: "bigint", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reminder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reminder_Entries_EntryId",
                        column: x => x.EntryId,
                        principalTable: "Entries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reminder_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Reminder_EntryId",
                table: "Reminder",
                column: "EntryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reminder_UserId",
                table: "Reminder",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reminder");

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
    }
}
