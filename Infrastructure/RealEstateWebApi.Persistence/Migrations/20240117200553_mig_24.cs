using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RealEstateWebApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_24 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_DeedStatuses_DeedStatusId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Fronts_FrontId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_HeatingTypes_HeatingTypeId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_InternetTypes_InternetTypeId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_UsingStatuses_UsingStatusId",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_DeedStatusId",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_FrontId",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_HeatingTypeId",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_UsingStatusId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "FrontId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "IsSmartHome",
                table: "Properties");

            migrationBuilder.RenameColumn(
                name: "BathRoomCount",
                table: "Properties",
                newName: "BathroomCount");

            migrationBuilder.RenameColumn(
                name: "Landscape",
                table: "Properties",
                newName: "Tourism_GroundSurvey");

            migrationBuilder.RenameColumn(
                name: "KonumIFrame",
                table: "Properties",
                newName: "Tourism_BuildingStatus");

            migrationBuilder.RenameColumn(
                name: "InternetTypeId",
                table: "Properties",
                newName: "PropertyCategoryId");

            migrationBuilder.RenameColumn(
                name: "BalconyCount",
                table: "Properties",
                newName: "VehicleCapacity");

            migrationBuilder.RenameColumn(
                name: "Aidat",
                table: "Properties",
                newName: "SectionAndRoomCount");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_InternetTypeId",
                table: "Properties",
                newName: "IX_Properties_PropertyCategoryId");

            migrationBuilder.AddColumn<long>(
                name: "PropertyStatusId",
                table: "PropertyTypes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "PropertyCategoryId",
                table: "PropertyStatuses",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<long>(
                name: "UsingStatusId",
                table: "Properties",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<double>(
                name: "RoomCount",
                table: "Properties",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<double>(
                name: "LocationLon",
                table: "Properties",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "LocationLat",
                table: "Properties",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LivingRoomCount",
                table: "Properties",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<bool>(
                name: "IsOnSite",
                table: "Properties",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<bool>(
                name: "IsFurnished",
                table: "Properties",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<bool>(
                name: "IsAvailableLoan",
                table: "Properties",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<long>(
                name: "HeatingTypeId",
                table: "Properties",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "DeedStatusId",
                table: "Properties",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "BuildingTotalFloor",
                table: "Properties",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "BuildingFloor",
                table: "Properties",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "BuildingAge",
                table: "Properties",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<bool>(
                name: "AlcoholLicense",
                table: "Properties",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApartCount",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BathRoomCount",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BedCount",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BlockNo",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BuildingCount",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BuildingStatus",
                table: "Properties",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BuildingType",
                table: "Properties",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CeilingHeightMeters",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Commercial_Deposit",
                table: "Properties",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Commercial_DepositCurrency",
                table: "Properties",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DailySaleFuelLiter",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Deposit",
                table: "Properties",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepositCurrency",
                table: "Properties",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Properties",
                type: "character varying(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ElevatorCount",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntryHeightMeters",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ExchangeForBuilding",
                table: "Properties",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Fees",
                table: "Properties",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeesCurrency",
                table: "Properties",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FloorAreaRatio",
                table: "Properties",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Gabari",
                table: "Properties",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GroundSurvey",
                table: "Properties",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IndoorSquareMeters",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsBalcony",
                table: "Properties",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsBarter",
                table: "Properties",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsElevator",
                table: "Properties",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LayoutNo",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MiningLicense",
                table: "Properties",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OutdoorSquareMeters",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PeopleCapacity",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlotNo",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PriceCurrency",
                table: "Properties",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PumpCount",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReconstructionStatus",
                table: "Properties",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RemainingInstallment",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RemainingPaymentAmount",
                table: "Properties",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Residential_BuildingAge",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Residential_BuildingFloor",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Residential_BuildingTotalFloor",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Residential_DeedStatusId",
                table: "Properties",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Residential_Deposit",
                table: "Properties",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Residential_DepositCurrency",
                table: "Properties",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Residential_Fees",
                table: "Properties",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Residential_FeesCurrency",
                table: "Properties",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Residential_HeatingTypeId",
                table: "Properties",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Residential_IsAvailableLoan",
                table: "Properties",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Residential_IsBarter",
                table: "Properties",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Residential_UsingStatusId",
                table: "Properties",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpaceSquareMeters",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StarCount",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TableCapacity",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalLandAcres",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tourism_BuildingAge",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tourism_BuildingTotalFloor",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tourism_IndoorSquareMeters",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Tourism_IsAvailableLoan",
                table: "Properties",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tourism_OutdoorSquareMeters",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tourism_RoomCount",
                table: "Properties",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Discriminator",
                table: "Files",
                type: "character varying(21)",
                maxLength: 21,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<double>(
                name: "RoomCount",
                table: "CustomerOwnedProperties",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "PropertyCategories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyCategories", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 753, DateTimeKind.Utc).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 753, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 753, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 753, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "Key" },
                values: new object[] { new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(3820), "GDOWN" });

            migrationBuilder.InsertData(
                table: "EntrySubTypes",
                columns: new[] { "Id", "CreatedDate", "EntryTypeId", "IsActive", "IsDeleted", "Key", "Title", "UpdatedDate" },
                values: new object[] { 13L, new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(3820), 4L, true, false, "PDOWN", "Sözleşme Bitti", null });

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 754, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 755, DateTimeKind.Utc).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 755, DateTimeKind.Utc).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 755, DateTimeKind.Utc).AddTicks(3280));

            migrationBuilder.InsertData(
                table: "PropertyCategories",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 1, 17, 20, 5, 52, 755, DateTimeKind.Utc).AddTicks(3800), true, false, "Konut", null },
                    { 2L, new DateTime(2024, 1, 17, 20, 5, 52, 755, DateTimeKind.Utc).AddTicks(3800), true, false, "İşyeri", null },
                    { 3L, new DateTime(2024, 1, 17, 20, 5, 52, 755, DateTimeKind.Utc).AddTicks(3800), true, false, "Arsa", null },
                    { 4L, new DateTime(2024, 1, 17, 20, 5, 52, 755, DateTimeKind.Utc).AddTicks(3800), true, false, "Bina", null },
                    { 5L, new DateTime(2024, 1, 17, 20, 5, 52, 755, DateTimeKind.Utc).AddTicks(3800), true, false, "Turistik Tesis", null }
                });

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "PropertyCategoryId" },
                values: new object[] { new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(5260), 1L });

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "PropertyCategoryId" },
                values: new object[] { new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(5260), 1L });

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "PropertyCategoryId", "Title" },
                values: new object[] { new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(5260), 1L, "Günlük Kiralık" });

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "PropertyCategoryId", "Title" },
                values: new object[] { new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(5260), 1L, "Devren Satılık Konut" });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "PropertyStatusId" },
                values: new object[] { new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7630), 1L });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "PropertyStatusId", "Title" },
                values: new object[] { new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7630), 1L, "Residence" });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "PropertyStatusId" },
                values: new object[] { new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7630), 1L });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "PropertyStatusId", "Title" },
                values: new object[] { new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7630), 1L, "Villa" });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "PropertyStatusId", "Title" },
                values: new object[] { new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7640), 1L, "Çiftlik Evi" });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "PropertyStatusId", "Title" },
                values: new object[] { new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7640), 1L, "Köşk & Konak" });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "PropertyStatusId", "Title" },
                values: new object[] { new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7640), 1L, "Yalı" });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "PropertyStatusId", "Title" },
                values: new object[] { new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7640), 1L, "Yalı Dairesi" });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "PropertyStatusId", "Title" },
                values: new object[] { new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7640), 1L, "Yazlık" });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "PropertyStatusId", "Title" },
                values: new object[] { new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7640), 1L, "Prefabrik Ev" });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "PropertyStatusId", "Title" },
                values: new object[] { new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7640), 1L, "Kooperatif" });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "PropertyStatusId", "Title" },
                values: new object[] { new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7640), 2L, "Daire" });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "PropertyStatusId", "Title" },
                values: new object[] { new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7640), 2L, "Residence" });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "PropertyStatusId", "Title" },
                values: new object[] { new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7640), 2L, "Müstakil Ev" });

            migrationBuilder.InsertData(
                table: "PropertyTypes",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "PropertyStatusId", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 15L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7650), true, false, 2L, "Villa", null },
                    { 16L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7650), true, false, 2L, "Çiftlik Evi", null },
                    { 17L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7650), true, false, 2L, "Köşk & Konak", null },
                    { 18L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7650), true, false, 2L, "Yalı", null },
                    { 19L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7650), true, false, 2L, "Yalı Dairesi", null },
                    { 20L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7650), true, false, 3L, "Daire", null },
                    { 21L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7650), true, false, 3L, "Residence", null },
                    { 22L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7650), true, false, 3L, "Müstakil Ev", null },
                    { 23L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7650), true, false, 3L, "Villa", null },
                    { 24L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7650), true, false, 3L, "Çiftlik Evi", null },
                    { 25L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7650), true, false, 3L, "Köşk & Konak", null },
                    { 26L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7660), true, false, 3L, "Yalı", null },
                    { 27L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7660), true, false, 3L, "Yalı Dairesi", null },
                    { 28L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7660), true, false, 4L, "Daire", null },
                    { 29L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7660), true, false, 4L, "Villa", null }
                });

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 761, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 761, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 20, 5, 52, 761, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.InsertData(
                table: "PropertyStatuses",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "PropertyCategoryId", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 5L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(5260), true, false, 2L, "Satılık", null },
                    { 6L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(5260), true, false, 2L, "Kiralık", null },
                    { 7L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(5260), true, false, 2L, "Devren Satılık", null },
                    { 8L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(5260), true, false, 2L, "Devren Kiralık", null },
                    { 9L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(5260), true, false, 3L, "Satılık", null },
                    { 10L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(5260), true, false, 3L, "Kiralık", null },
                    { 11L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(5260), true, false, 4L, "Satılık", null },
                    { 12L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(5270), true, false, 4L, "Kiralık", null },
                    { 13L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(5270), true, false, 5L, "Satılık", null },
                    { 14L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(5270), true, false, 5L, "Kiralık", null }
                });

            migrationBuilder.InsertData(
                table: "PropertyTypes",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "PropertyStatusId", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 30L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7660), true, false, 5L, "Akaryakıt İstasyonu", null },
                    { 31L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7660), true, false, 5L, "Apartman Dairesi", null },
                    { 32L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7660), true, false, 5L, "Atölye ", null },
                    { 33L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7660), true, false, 5L, "AVM", null },
                    { 34L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7660), true, false, 5L, "Büfe", null },
                    { 35L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7660), true, false, 5L, "Büro & Ofis", null },
                    { 36L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7660), true, false, 5L, "Cafe & Bar", null },
                    { 37L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7670), true, false, 5L, "Çiftlik", null },
                    { 38L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7670), true, false, 5L, "Depo & Antrepo", null },
                    { 39L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7670), true, false, 5L, "Düğün Salonu", null },
                    { 40L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7670), true, false, 5L, "Dükkan & Mağaza", null },
                    { 41L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7670), true, false, 5L, "Enerji Santralleri", null },
                    { 42L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7670), true, false, 5L, "Fabrika", null },
                    { 43L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7670), true, false, 5L, "Garaj & Park Yeri", null },
                    { 44L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7670), true, false, 5L, "İmalathane ", null },
                    { 45L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7670), true, false, 5L, "İş Hanı Katı & Ofisi", null },
                    { 46L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7670), true, false, 5L, "Kantin", null },
                    { 47L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7670), true, false, 5L, "Kır & Kahvaltı Bahçesi", null },
                    { 48L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7680), true, false, 5L, "Kıraathane", null },
                    { 49L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7680), true, false, 5L, "Komple Bina", null },
                    { 50L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7680), true, false, 5L, "Maden Ocağı", null },
                    { 51L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7680), true, false, 5L, "Otopark", null },
                    { 52L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7680), true, false, 5L, "Pastane & Fırın", null },
                    { 53L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7680), true, false, 5L, "Pazar Yeri", null },
                    { 54L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7680), true, false, 5L, "Plaza", null },
                    { 55L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7680), true, false, 5L, "Plaza Katı", null },
                    { 56L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7680), true, false, 5L, "Prefabrik Yapı", null },
                    { 57L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7680), true, false, 5L, "Radyo İstasyonu", null },
                    { 58L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7690), true, false, 5L, "Residence Katı & Ofisi", null },
                    { 59L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7690), true, false, 5L, "Restoran & Lokanta", null },
                    { 60L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7690), true, false, 5L, "Sağlık Merkezi", null },
                    { 61L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7690), true, false, 5L, "Sinema & Konferans Salonu", null },
                    { 62L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7690), true, false, 5L, "SPA, Hamam & Sauna", null },
                    { 63L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7690), true, false, 5L, "Spor Tesisi ", null },
                    { 64L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7690), true, false, 5L, "Villa", null },
                    { 65L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7690), true, false, 5L, "Yurt", null },
                    { 66L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7690), true, false, 6L, "Akaryakıt İstasyonu", null },
                    { 67L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7690), true, false, 6L, "Apartman Dairesi", null },
                    { 68L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7690), true, false, 6L, "Atölye", null },
                    { 69L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7690), true, false, 6L, "AVM", null },
                    { 70L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7700), true, false, 6L, "Büfe", null },
                    { 71L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7700), true, false, 6L, "Büro & Ofis", null },
                    { 72L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7700), true, false, 6L, "Cafe & Bar", null },
                    { 73L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7700), true, false, 6L, "Çiftlik", null },
                    { 74L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7700), true, false, 6L, "Depo & Antrepo", null },
                    { 75L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7700), true, false, 6L, "Düğün Salonu", null },
                    { 76L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7700), true, false, 6L, "Dükkan & Mağaza", null },
                    { 77L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7700), true, false, 6L, "Eczane & Medikal", null },
                    { 78L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7700), true, false, 6L, "Fabrika", null },
                    { 79L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7710), true, false, 6L, "Fotoğraf Stüdyosu", null },
                    { 80L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7710), true, false, 6L, "Garaj", null },
                    { 81L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7710), true, false, 6L, "Hazır & Sanal Ofis", null },
                    { 82L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7710), true, false, 6L, "İmalathane", null },
                    { 83L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7710), true, false, 6L, "İş Hanı Katı & Ofisi", null },
                    { 84L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7710), true, false, 6L, "Kantin", null },
                    { 85L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7710), true, false, 6L, "Kır & Kahvaltı Bahçesi ", null },
                    { 86L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7710), true, false, 6L, "Kıraathane", null },
                    { 87L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7710), true, false, 6L, "Komple Bina", null },
                    { 88L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7710), true, false, 6L, "Kuaför & Güzellik Merkezi", null },
                    { 89L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7710), true, false, 6L, "Maden Ocağı", null },
                    { 90L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7720), true, false, 6L, "Market", null },
                    { 91L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7720), true, false, 6L, "Muayenehane", null },
                    { 92L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7720), true, false, 6L, "Okul & Kurs", null },
                    { 93L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7720), true, false, 6L, "Otopark", null },
                    { 94L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7720), true, false, 6L, "Oto Yıkama & Kuaför", null },
                    { 95L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7720), true, false, 6L, "Pastane & Fırın", null },
                    { 96L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7720), true, false, 6L, "Pazar Yeri", null },
                    { 97L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7720), true, false, 6L, "Plaza", null },
                    { 98L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7720), true, false, 6L, "Plaza Katı & Ofisi", null },
                    { 99L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7720), true, false, 6L, "Prova & Kayıt Stüdyosu", null },
                    { 100L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7720), true, false, 6L, "Radyo İstasyonu & TV Kanalı", null },
                    { 101L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7730), true, false, 6L, "Residence Katı & Ofisi", null },
                    { 102L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7730), true, false, 6L, "Restoran & Lokanta", null },
                    { 103L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7730), true, false, 6L, "Sağlık Merkezi", null },
                    { 104L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7730), true, false, 6L, "Sinema & Konferans Salonu", null },
                    { 105L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7730), true, false, 6L, "Spa, Hamam & Sauna", null },
                    { 106L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7730), true, false, 6L, "Spor Tesisi", null },
                    { 107L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7730), true, false, 6L, "Taksi Durağı", null },
                    { 108L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7730), true, false, 6L, "Tamirhane", null },
                    { 109L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7730), true, false, 6L, "Villa", null },
                    { 110L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7730), true, false, 6L, "Yurt", null },
                    { 111L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7740), true, false, 7L, "Acente", null },
                    { 112L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7740), true, false, 7L, "Akaryakıt İstasyonu", null },
                    { 113L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7740), true, false, 7L, "Aktar & Baharatçı", null },
                    { 114L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7740), true, false, 7L, "Anaokulu & Kreş", null },
                    { 115L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7740), true, false, 7L, "Apartman Dairesi", null },
                    { 116L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7740), true, false, 7L, "Araç Showroom & Servis", null },
                    { 117L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7740), true, false, 7L, "Atölye", null },
                    { 118L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7740), true, false, 7L, "AVM Standı", null },
                    { 119L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7740), true, false, 7L, "Balıkçı", null },
                    { 120L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7740), true, false, 7L, "Bar", null },
                    { 121L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7740), true, false, 7L, "Bijuteri", null },
                    { 122L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7740), true, false, 7L, "Börekçi", null },
                    { 123L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7750), true, false, 7L, "Büfe", null },
                    { 124L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7750), true, false, 7L, "Büro & Ofis", null },
                    { 125L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7750), true, false, 7L, "Cafe", null },
                    { 126L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7750), true, false, 7L, "CD & DVD Dükkanı", null },
                    { 127L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7750), true, false, 7L, "Cep Telefonu Dükkanı", null },
                    { 128L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7750), true, false, 7L, "Çamaşırhane", null },
                    { 129L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7750), true, false, 7L, "Çay Ocağı", null },
                    { 130L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7750), true, false, 7L, "Çiçekçi & Fidanlık", null },
                    { 131L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7750), true, false, 7L, "Çiftlik", null },
                    { 132L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7750), true, false, 7L, "Depo & Antrepo", null },
                    { 133L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7750), true, false, 7L, "Düğün Salonu", null },
                    { 134L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7760), true, false, 7L, "Dükkan & Mağaza", null },
                    { 135L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7760), true, false, 7L, "Eczane & Medikal", null },
                    { 136L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7760), true, false, 7L, "Elektrikçi & Hırdavatçı", null },
                    { 137L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7760), true, false, 7L, "Elektronik Mağazası", null },
                    { 138L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7760), true, false, 7L, "Etkinlik & Performans Salonu", null },
                    { 139L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7760), true, false, 7L, "Fabrika & Üretim Tesisi", null },
                    { 140L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7760), true, false, 7L, "Fatura Merkezi", null },
                    { 141L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7760), true, false, 7L, "Fotoğraf Stüdyosu", null },
                    { 142L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7760), true, false, 7L, "Gece Kulübü & Disko", null },
                    { 143L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7760), true, false, 7L, "Giyim Mağazası", null },
                    { 144L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7760), true, false, 7L, "Gözlükçü", null },
                    { 145L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7770), true, false, 7L, "Halı Yıkama", null },
                    { 146L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7770), true, false, 7L, "Huzur Evi", null },
                    { 147L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7770), true, false, 7L, "İmalathane", null },
                    { 148L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7770), true, false, 7L, "İnternet & Oyun Cafe", null },
                    { 149L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7770), true, false, 7L, "İş Hanı", null },
                    { 150L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7770), true, false, 7L, "İş Hanı Katı & Ofisi", null },
                    { 151L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7770), true, false, 7L, "Kantin", null },
                    { 152L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7770), true, false, 7L, "Kasap", null },
                    { 153L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7770), true, false, 7L, "Kır & Kahvaltı Bahçesi ", null },
                    { 154L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7770), true, false, 7L, "Kıraathane", null },
                    { 155L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7770), true, false, 7L, "Kırtasiye", null },
                    { 156L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7780), true, false, 7L, "Kozmetik Mağazası", null },
                    { 157L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7780), true, false, 7L, "Kuaför & Güzellik Merkezi", null },
                    { 158L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7780), true, false, 7L, "Kurs & Eğitim Merkezi", null },
                    { 159L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7780), true, false, 7L, "Kuru Temizleme", null },
                    { 160L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7780), true, false, 7L, "Kuruyemişçi", null },
                    { 161L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7780), true, false, 7L, "Kuyumcu", null },
                    { 162L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7780), true, false, 7L, "Lunapark", null },
                    { 163L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7780), true, false, 7L, "Maden Ocağı", null },
                    { 164L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7780), true, false, 7L, "Manav", null },
                    { 165L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7780), true, false, 7L, "Market", null },
                    { 166L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7780), true, false, 7L, "Matbaa", null },
                    { 167L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7780), true, false, 7L, "Modaevi", null },
                    { 168L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7790), true, false, 7L, "Muayenehane", null },
                    { 169L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7790), true, false, 7L, "Nakliyat & Kargo", null },
                    { 170L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7790), true, false, 7L, "Nalbur", null },
                    { 171L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7790), true, false, 7L, "Okul", null },
                    { 172L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7790), true, false, 7L, "Otopark / Garaj", null },
                    { 173L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7790), true, false, 7L, "Oto Servis & Bakım", null },
                    { 174L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7790), true, false, 7L, "Oto Yedek Parça", null },
                    { 175L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7790), true, false, 7L, "Oto Yıkama & Kuaför", null },
                    { 176L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7790), true, false, 7L, "Öğrenci Yurdu", null },
                    { 177L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7790), true, false, 7L, "Pastane & Fırın & Tatlıcı", null },
                    { 178L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7790), true, false, 7L, "Pazar Yeri", null },
                    { 179L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7800), true, false, 7L, "Pet Shop", null },
                    { 180L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7800), true, false, 7L, "Plaza", null },
                    { 181L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7800), true, false, 7L, "Plaza Katı & Ofisi", null },
                    { 182L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7800), true, false, 7L, "Prova & Kayıt Stüdyosu", null },
                    { 183L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7800), true, false, 7L, "Radyo İstasyonu & TV Kanalı", null },
                    { 184L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7800), true, false, 7L, "Residence Katı & Ofisi", null },
                    { 185L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7800), true, false, 7L, "Restoran & Lokanta", null },
                    { 186L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7800), true, false, 7L, "Saat Mağazası", null },
                    { 187L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7800), true, false, 7L, "Sağlık Merkezi", null },
                    { 188L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7800), true, false, 7L, "Sebze & Meyve Hali", null },
                    { 189L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7800), true, false, 7L, "Sinema & Konferans Salonu", null },
                    { 190L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7800), true, false, 7L, "Soğuk Hava Deposu", null },
                    { 191L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7800), true, false, 7L, "SPA, Hamam & Sauna", null },
                    { 192L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7810), true, false, 7L, "Spor Tesisi", null },
                    { 193L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7810), true, false, 7L, "Su & Tüp Bayi", null },
                    { 194L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7810), true, false, 7L, "Şans Oyunları Bayisi", null },
                    { 195L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7810), true, false, 7L, "Şarküteri", null },
                    { 196L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7810), true, false, 7L, "Taksi Durağı", null },
                    { 197L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7810), true, false, 7L, "Tamirhane", null },
                    { 198L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7810), true, false, 7L, "Tekel Bayi", null },
                    { 199L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7810), true, false, 7L, "Teknik Servis", null },
                    { 200L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7820), true, false, 7L, "Terzi", null },
                    { 201L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7820), true, false, 7L, "Tuhafiye", null },
                    { 202L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7820), true, false, 7L, "Veteriner", null },
                    { 203L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7820), true, false, 7L, "Züccaciye", null },
                    { 204L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7820), true, false, 8L, "Acente", null },
                    { 205L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7820), true, false, 8L, "Akaryakıt İstasyonu", null },
                    { 206L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7820), true, false, 8L, "Aktar & Baharatçı", null },
                    { 207L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7820), true, false, 8L, "Anaokulu & Kreş", null },
                    { 208L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7820), true, false, 8L, "Apartman Dairesi", null },
                    { 209L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7830), true, false, 8L, "Araç Showroom & Servis", null },
                    { 210L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7830), true, false, 8L, "Atölye", null },
                    { 211L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7830), true, false, 8L, "AVM Standı", null },
                    { 212L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7830), true, false, 8L, "Balıkçı", null },
                    { 213L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7830), true, false, 8L, "Bar", null },
                    { 214L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7830), true, false, 8L, "Bijuteri", null },
                    { 215L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7830), true, false, 8L, "Börekçi", null },
                    { 216L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7830), true, false, 8L, "Büfe", null },
                    { 217L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7830), true, false, 8L, "Büro & Ofis", null },
                    { 218L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7830), true, false, 8L, "Cafe", null },
                    { 219L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7830), true, false, 8L, "CD & DVD Dükkanı", null },
                    { 220L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7830), true, false, 8L, "Cep Telefonu Dükkanı", null },
                    { 221L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7830), true, false, 8L, "Çamaşırhane", null },
                    { 222L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7840), true, false, 8L, "Çay Ocağı", null },
                    { 223L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7840), true, false, 8L, "Çiçekçi & Fidanlık", null },
                    { 224L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7840), true, false, 8L, "Çiftlik", null },
                    { 225L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7840), true, false, 8L, "Depo & Antrepo", null },
                    { 226L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7840), true, false, 8L, "Düğün Salonu", null },
                    { 227L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7840), true, false, 8L, "Dükkan & Mağaza", null },
                    { 228L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7840), true, false, 8L, "Eczane", null },
                    { 229L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7840), true, false, 8L, "Elektrikçi & Hırdavatçı", null },
                    { 230L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7840), true, false, 8L, "Elektronik", null },
                    { 231L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7840), true, false, 8L, "Fabrika", null },
                    { 232L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7840), true, false, 8L, "Fatura Merkezi", null },
                    { 233L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7850), true, false, 8L, "Fotoğraf Stüdyosu", null },
                    { 234L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7850), true, false, 8L, "Gece Kulübü & Disko", null },
                    { 235L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7850), true, false, 8L, "Giyim Mağazası", null },
                    { 236L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7850), true, false, 8L, "Gözlükçü", null },
                    { 237L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7850), true, false, 8L, "Halı Yıkama", null },
                    { 238L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7850), true, false, 8L, "Huzur Evi", null },
                    { 239L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7850), true, false, 8L, "İmalathane", null },
                    { 240L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7850), true, false, 8L, "İnternet & Oyun Cafe", null },
                    { 241L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7850), true, false, 8L, "İş Hanı", null },
                    { 242L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7850), true, false, 8L, "İş Hanı Katı & Ofisi", null },
                    { 243L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7850), true, false, 8L, "Kasap", null },
                    { 244L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7860), true, false, 8L, "Kır & Kahvaltı Bahçesi ", null },
                    { 245L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7860), true, false, 8L, "Kıraathane", null },
                    { 246L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7860), true, false, 8L, "Kırtasiye", null },
                    { 247L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7860), true, false, 8L, "Kozmetik Mağazası", null },
                    { 248L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7860), true, false, 8L, "Kuaför & Güzellik Merkezi", null },
                    { 249L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7860), true, false, 8L, "Kurs & Eğitim Merkezi", null },
                    { 250L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7860), true, false, 8L, "Kuru Temizleme", null },
                    { 251L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7860), true, false, 8L, "Kuruyemişçi", null },
                    { 252L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7860), true, false, 8L, "Kuyumcu", null },
                    { 253L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7860), true, false, 8L, "Lunapark", null },
                    { 254L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7860), true, false, 8L, "Maden Ocağı", null },
                    { 255L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7860), true, false, 8L, "Manav", null },
                    { 256L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7870), true, false, 8L, "Market", null },
                    { 257L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7870), true, false, 8L, "Matbaa", null },
                    { 258L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7870), true, false, 8L, "Medikal Market", null },
                    { 259L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7870), true, false, 8L, "Modaevi", null },
                    { 260L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7870), true, false, 8L, "Muayenehane", null },
                    { 261L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7870), true, false, 8L, "Nakliyat & Kargo", null },
                    { 262L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7870), true, false, 8L, "Nalbur", null },
                    { 263L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7870), true, false, 8L, "Okul", null },
                    { 264L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7870), true, false, 8L, "Otopark / Garaj", null },
                    { 265L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7870), true, false, 8L, "Oto Servis & Bakım", null },
                    { 266L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7870), true, false, 8L, "Oto Yedek Parça", null },
                    { 267L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7870), true, false, 8L, "Oto Yıkama & Kuaför", null },
                    { 268L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7880), true, false, 8L, "Öğrenci Yurdu", null },
                    { 269L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7880), true, false, 8L, "Pastane & Fırın", null },
                    { 270L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7880), true, false, 8L, "Pazar Yeri", null },
                    { 271L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7880), true, false, 8L, "Pet Shop", null },
                    { 272L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7880), true, false, 8L, "Plaza", null },
                    { 273L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7880), true, false, 8L, "Plaza Katı & Ofisi", null },
                    { 274L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7880), true, false, 8L, "Prova & Kayıt Stüdyosu", null },
                    { 275L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7880), true, false, 8L, "Radyo İstasyonu & TV Kanalı", null },
                    { 276L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7880), true, false, 8L, "Residence Katı & Ofisi", null },
                    { 277L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7880), true, false, 8L, "Restoran & Lokanta", null },
                    { 278L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7880), true, false, 8L, "Saat Mağazası", null },
                    { 279L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7880), true, false, 8L, "Sağlık Merkezi", null },
                    { 280L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7890), true, false, 8L, "Sebze & Meyve Hali", null },
                    { 281L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7890), true, false, 8L, "Sinema & Konferans Salonu", null },
                    { 282L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7890), true, false, 8L, "Soğuk Hava Deposu", null },
                    { 283L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7890), true, false, 8L, "SPA, Hamam & Sauna", null },
                    { 284L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7890), true, false, 8L, "Spor Tesisi", null },
                    { 285L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7890), true, false, 8L, "Su & Tüp Bayi", null },
                    { 286L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7890), true, false, 8L, "Şans Oyunları Bayisi", null },
                    { 287L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7890), true, false, 8L, "Şarküteri", null },
                    { 288L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7890), true, false, 8L, "Taksi Durağı", null },
                    { 289L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7890), true, false, 8L, "Tamirhane", null },
                    { 290L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7890), true, false, 8L, "Tekel Bayi", null },
                    { 291L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7890), true, false, 8L, "Teknik Servis", null },
                    { 292L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7900), true, false, 8L, "Terzi", null },
                    { 293L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7900), true, false, 8L, "Tuhafiye", null },
                    { 294L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7900), true, false, 8L, "Tuvalet", null },
                    { 295L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7900), true, false, 8L, "Veteriner", null },
                    { 296L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7900), true, false, 8L, "Züccaciye", null },
                    { 297L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7900), true, false, 13L, "Otel", null },
                    { 298L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7900), true, false, 13L, "Apart Otel", null },
                    { 299L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7900), true, false, 13L, "Butik Otel", null },
                    { 300L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7900), true, false, 13L, "Motel", null },
                    { 301L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7900), true, false, 13L, "Pansiyon", null },
                    { 302L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7900), true, false, 13L, "Kamp Yeri (Mocamp)", null },
                    { 303L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7900), true, false, 13L, "Tatil Köyü", null },
                    { 304L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7910), true, false, 14L, "Otel", null },
                    { 305L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7910), true, false, 14L, "Apart Otel", null },
                    { 306L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7910), true, false, 14L, "Butik Otel", null },
                    { 307L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7910), true, false, 14L, "Motel", null },
                    { 308L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7910), true, false, 14L, "Pansiyon", null },
                    { 309L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7910), true, false, 14L, "Kamp Yeri (Mocamp)", null },
                    { 310L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7910), true, false, 14L, "Tatil Köyü", null },
                    { 311L, new DateTime(2024, 1, 17, 20, 5, 52, 759, DateTimeKind.Utc).AddTicks(7910), true, false, 14L, "Plaj", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropertyTypes_PropertyStatusId",
                table: "PropertyTypes",
                column: "PropertyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyStatuses_PropertyCategoryId",
                table: "PropertyStatuses",
                column: "PropertyCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_PropertyCategories_PropertyCategoryId",
                table: "Properties",
                column: "PropertyCategoryId",
                principalTable: "PropertyCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyStatuses_PropertyCategories_PropertyCategoryId",
                table: "PropertyStatuses",
                column: "PropertyCategoryId",
                principalTable: "PropertyCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyTypes_PropertyStatuses_PropertyStatusId",
                table: "PropertyTypes",
                column: "PropertyStatusId",
                principalTable: "PropertyStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_PropertyCategories_PropertyCategoryId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyStatuses_PropertyCategories_PropertyCategoryId",
                table: "PropertyStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyTypes_PropertyStatuses_PropertyStatusId",
                table: "PropertyTypes");

            migrationBuilder.DropTable(
                name: "PropertyCategories");

            migrationBuilder.DropIndex(
                name: "IX_PropertyTypes_PropertyStatusId",
                table: "PropertyTypes");

            migrationBuilder.DropIndex(
                name: "IX_PropertyStatuses_PropertyCategoryId",
                table: "PropertyStatuses");

            migrationBuilder.DeleteData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 240L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 243L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 244L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 245L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 246L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 247L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 248L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 249L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 250L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 251L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 252L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 253L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 254L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 255L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 256L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 257L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 258L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 259L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 260L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 261L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 262L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 263L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 264L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 265L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 266L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 267L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 268L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 269L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 270L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 271L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 272L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 273L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 274L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 275L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 276L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 277L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 278L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 279L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 280L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 281L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 282L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 283L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 284L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 285L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 286L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 287L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 288L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 289L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 290L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 291L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 292L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 293L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 294L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 295L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 296L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 297L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 298L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 299L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 300L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 301L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 302L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 303L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 304L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 305L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 306L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 307L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 308L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 309L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 310L);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 311L);

            migrationBuilder.DeleteData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DropColumn(
                name: "PropertyStatusId",
                table: "PropertyTypes");

            migrationBuilder.DropColumn(
                name: "PropertyCategoryId",
                table: "PropertyStatuses");

            migrationBuilder.DropColumn(
                name: "AlcoholLicense",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "ApartCount",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "BathRoomCount",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "BedCount",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "BlockNo",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "BuildingCount",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "BuildingStatus",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "BuildingType",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "CeilingHeightMeters",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Commercial_Deposit",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Commercial_DepositCurrency",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "DailySaleFuelLiter",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Deposit",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "DepositCurrency",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "ElevatorCount",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "EntryHeightMeters",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "ExchangeForBuilding",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Fees",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "FeesCurrency",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "FloorAreaRatio",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Gabari",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "GroundSurvey",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "IndoorSquareMeters",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "IsBalcony",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "IsBarter",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "IsElevator",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "LayoutNo",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "MiningLicense",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "OutdoorSquareMeters",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "PeopleCapacity",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "PlotNo",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "PriceCurrency",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "PumpCount",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "ReconstructionStatus",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "RemainingInstallment",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "RemainingPaymentAmount",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Residential_BuildingAge",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Residential_BuildingFloor",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Residential_BuildingTotalFloor",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Residential_DeedStatusId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Residential_Deposit",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Residential_DepositCurrency",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Residential_Fees",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Residential_FeesCurrency",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Residential_HeatingTypeId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Residential_IsAvailableLoan",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Residential_IsBarter",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Residential_UsingStatusId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "SpaceSquareMeters",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "StarCount",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "TableCapacity",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "TotalLandAcres",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Tourism_BuildingAge",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Tourism_BuildingTotalFloor",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Tourism_IndoorSquareMeters",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Tourism_IsAvailableLoan",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Tourism_OutdoorSquareMeters",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Tourism_RoomCount",
                table: "Properties");

            migrationBuilder.RenameColumn(
                name: "BathroomCount",
                table: "Properties",
                newName: "BathRoomCount");

            migrationBuilder.RenameColumn(
                name: "VehicleCapacity",
                table: "Properties",
                newName: "BalconyCount");

            migrationBuilder.RenameColumn(
                name: "Tourism_GroundSurvey",
                table: "Properties",
                newName: "Landscape");

            migrationBuilder.RenameColumn(
                name: "Tourism_BuildingStatus",
                table: "Properties",
                newName: "KonumIFrame");

            migrationBuilder.RenameColumn(
                name: "SectionAndRoomCount",
                table: "Properties",
                newName: "Aidat");

            migrationBuilder.RenameColumn(
                name: "PropertyCategoryId",
                table: "Properties",
                newName: "InternetTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_PropertyCategoryId",
                table: "Properties",
                newName: "IX_Properties_InternetTypeId");

            migrationBuilder.AlterColumn<long>(
                name: "UsingStatusId",
                table: "Properties",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RoomCount",
                table: "Properties",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "LocationLon",
                table: "Properties",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<double>(
                name: "LocationLat",
                table: "Properties",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<int>(
                name: "LivingRoomCount",
                table: "Properties",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsOnSite",
                table: "Properties",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsFurnished",
                table: "Properties",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsAvailableLoan",
                table: "Properties",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "HeatingTypeId",
                table: "Properties",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "DeedStatusId",
                table: "Properties",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BuildingTotalFloor",
                table: "Properties",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BuildingFloor",
                table: "Properties",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BuildingAge",
                table: "Properties",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FrontId",
                table: "Properties",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<bool>(
                name: "IsSmartHome",
                table: "Properties",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Discriminator",
                table: "Files",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(21)",
                oldMaxLength: 21);

            migrationBuilder.AlterColumn<int>(
                name: "RoomCount",
                table: "CustomerOwnedProperties",
                type: "integer",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

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
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "Key" },
                values: new object[] { new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(2880), "DOWN" });

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 11, 21, 54, 28, 939, DateTimeKind.Utc).AddTicks(3300));

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
                columns: new[] { "CreatedDate", "Title" },
                values: new object[] { new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9000), "Devren Satılık" });

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "Title" },
                values: new object[] { new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9000), "Devren Kiralık" });

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
                columns: new[] { "CreatedDate", "Title" },
                values: new object[] { new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9500), "Residans" });

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
                columns: new[] { "CreatedDate", "Title" },
                values: new object[] { new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9500), "Müstakil Bina" });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "Title" },
                values: new object[] { new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9500), "Villa" });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "Title" },
                values: new object[] { new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9500), "Çiftlik Evi" });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "Title" },
                values: new object[] { new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9510), "Yazlık" });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "Title" },
                values: new object[] { new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9510), "Büro/Ofis" });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "Title" },
                values: new object[] { new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9510), "Depo/Antrepo" });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "Title" },
                values: new object[] { new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9510), "Dükkan/Mağaza" });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "Title" },
                values: new object[] { new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9510), "Plaza" });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "Title" },
                values: new object[] { new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9510), "Palaza Katı" });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "Title" },
                values: new object[] { new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9510), "Sağlık Merkezi" });

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "Title" },
                values: new object[] { new DateTime(2023, 8, 11, 21, 54, 28, 943, DateTimeKind.Utc).AddTicks(9510), "Spor Tesisi" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Properties_DeedStatusId",
                table: "Properties",
                column: "DeedStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_FrontId",
                table: "Properties",
                column: "FrontId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_HeatingTypeId",
                table: "Properties",
                column: "HeatingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_UsingStatusId",
                table: "Properties",
                column: "UsingStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_DeedStatuses_DeedStatusId",
                table: "Properties",
                column: "DeedStatusId",
                principalTable: "DeedStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Fronts_FrontId",
                table: "Properties",
                column: "FrontId",
                principalTable: "Fronts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_HeatingTypes_HeatingTypeId",
                table: "Properties",
                column: "HeatingTypeId",
                principalTable: "HeatingTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_InternetTypes_InternetTypeId",
                table: "Properties",
                column: "InternetTypeId",
                principalTable: "InternetTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_UsingStatuses_UsingStatusId",
                table: "Properties",
                column: "UsingStatusId",
                principalTable: "UsingStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
