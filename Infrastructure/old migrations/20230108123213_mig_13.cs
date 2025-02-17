using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RealEstateWebApi.Persistence.Migrations
{
    public partial class mig_13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerOwnedShortProperties_ShortProperties_ShortPropertyId",
                table: "CustomerOwnedShortProperties");

            migrationBuilder.AlterColumn<long>(
                name: "ShortPropertyId",
                table: "CustomerOwnedShortProperties",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "PropertyListingDetailId",
                table: "CustomerOwnedShortProperties",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PropertyListingDetails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ListingId = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    ListingStoreName = table.Column<string>(type: "text", nullable: true),
                    ListingUserName = table.Column<string>(type: "text", nullable: true),
                    ListingPhoneNumbers = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DescriptionHtml = table.Column<string>(type: "text", nullable: true),
                    ListingDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    Neighborhood = table.Column<string>(type: "text", nullable: true),
                    LocationLat = table.Column<double>(type: "double precision", nullable: true),
                    LocationLon = table.Column<double>(type: "double precision", nullable: true),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    Currency = table.Column<string>(type: "text", nullable: true),
                    Category = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    ReconstructionStatus = table.Column<string>(type: "text", nullable: true),
                    StructureType = table.Column<string>(type: "text", nullable: true),
                    GrossSquareMeter = table.Column<int>(type: "integer", nullable: false),
                    UsableSquareMeter = table.Column<int>(type: "integer", nullable: false),
                    PricePerSquareMeter = table.Column<double>(type: "double precision", nullable: false),
                    IndoorAreaSquareMeter = table.Column<int>(type: "integer", nullable: false),
                    OutdoorAreaSquareMeter = table.Column<int>(type: "integer", nullable: false),
                    BlockNo = table.Column<string>(type: "text", nullable: true),
                    PlotNo = table.Column<string>(type: "text", nullable: true),
                    LayoutNo = table.Column<string>(type: "text", nullable: true),
                    FloorAreaRatio = table.Column<string>(type: "text", nullable: true),
                    Gabari = table.Column<string>(type: "text", nullable: true),
                    RoomCount = table.Column<double>(type: "double precision", nullable: false),
                    LivingRoomCount = table.Column<short>(type: "smallint", nullable: false),
                    BuildingAge = table.Column<string>(type: "text", nullable: true),
                    Floor = table.Column<string>(type: "text", nullable: true),
                    BuildingTotalFloor = table.Column<string>(type: "text", nullable: true),
                    ElevatorCount = table.Column<string>(type: "text", nullable: true),
                    InletHeight = table.Column<string>(type: "text", nullable: true),
                    HeatingType = table.Column<string>(type: "text", nullable: true),
                    BathroomCount = table.Column<short>(type: "smallint", nullable: false),
                    IsThereBalcony = table.Column<bool>(type: "boolean", nullable: false),
                    IsFurnished = table.Column<bool>(type: "boolean", nullable: false),
                    UsingStatus = table.Column<string>(type: "text", nullable: true),
                    IsOnSite = table.Column<bool>(type: "boolean", nullable: false),
                    SiteName = table.Column<string>(type: "text", nullable: true),
                    Fees = table.Column<double>(type: "double precision", nullable: false),
                    IsAvailableLoan = table.Column<bool>(type: "boolean", nullable: false),
                    DeedStatus = table.Column<string>(type: "text", nullable: true),
                    FromProfile = table.Column<string>(type: "text", nullable: true),
                    IsBarter = table.Column<bool>(type: "boolean", nullable: false),
                    AlcoholLicense = table.Column<bool>(type: "boolean", nullable: false),
                    SoilSurvey = table.Column<bool>(type: "boolean", nullable: false),
                    Shlink = table.Column<string>(type: "text", nullable: true),
                    ShPhotoLinks = table.Column<string>(type: "text", nullable: false),
                    PhotoPaths = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyListingDetails", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 826, DateTimeKind.Utc).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 826, DateTimeKind.Utc).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 826, DateTimeKind.Utc).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 826, DateTimeKind.Utc).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 833, DateTimeKind.Utc).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 833, DateTimeKind.Utc).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 833, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 833, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 833, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 833, DateTimeKind.Utc).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 833, DateTimeKind.Utc).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 833, DateTimeKind.Utc).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 833, DateTimeKind.Utc).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 833, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 833, DateTimeKind.Utc).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 833, DateTimeKind.Utc).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 833, DateTimeKind.Utc).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 833, DateTimeKind.Utc).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 833, DateTimeKind.Utc).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 833, DateTimeKind.Utc).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 833, DateTimeKind.Utc).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 833, DateTimeKind.Utc).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 833, DateTimeKind.Utc).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 833, DateTimeKind.Utc).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 833, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 837, DateTimeKind.Utc).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 837, DateTimeKind.Utc).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 837, DateTimeKind.Utc).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 862, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 862, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 862, DateTimeKind.Utc).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 862, DateTimeKind.Utc).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 862, DateTimeKind.Utc).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 862, DateTimeKind.Utc).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 862, DateTimeKind.Utc).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 862, DateTimeKind.Utc).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 862, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 862, DateTimeKind.Utc).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 862, DateTimeKind.Utc).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 862, DateTimeKind.Utc).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 862, DateTimeKind.Utc).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 862, DateTimeKind.Utc).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 862, DateTimeKind.Utc).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 862, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 862, DateTimeKind.Utc).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 862, DateTimeKind.Utc).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 875, DateTimeKind.Utc).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 875, DateTimeKind.Utc).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 8, 12, 32, 10, 875, DateTimeKind.Utc).AddTicks(9245));

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOwnedShortProperties_PropertyListingDetailId",
                table: "CustomerOwnedShortProperties",
                column: "PropertyListingDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerOwnedShortProperties_PropertyListingDetails_Propert~",
                table: "CustomerOwnedShortProperties",
                column: "PropertyListingDetailId",
                principalTable: "PropertyListingDetails",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerOwnedShortProperties_ShortProperties_ShortPropertyId",
                table: "CustomerOwnedShortProperties",
                column: "ShortPropertyId",
                principalTable: "ShortProperties",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerOwnedShortProperties_PropertyListingDetails_Propert~",
                table: "CustomerOwnedShortProperties");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerOwnedShortProperties_ShortProperties_ShortPropertyId",
                table: "CustomerOwnedShortProperties");

            migrationBuilder.DropTable(
                name: "PropertyListingDetails");

            migrationBuilder.DropIndex(
                name: "IX_CustomerOwnedShortProperties_PropertyListingDetailId",
                table: "CustomerOwnedShortProperties");

            migrationBuilder.DropColumn(
                name: "PropertyListingDetailId",
                table: "CustomerOwnedShortProperties");

            migrationBuilder.AlterColumn<long>(
                name: "ShortPropertyId",
                table: "CustomerOwnedShortProperties",
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
                value: new DateTime(2022, 11, 18, 11, 19, 21, 977, DateTimeKind.Utc).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 977, DateTimeKind.Utc).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 977, DateTimeKind.Utc).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 977, DateTimeKind.Utc).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 980, DateTimeKind.Utc).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 980, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 980, DateTimeKind.Utc).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 980, DateTimeKind.Utc).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 980, DateTimeKind.Utc).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 980, DateTimeKind.Utc).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 980, DateTimeKind.Utc).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 980, DateTimeKind.Utc).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 980, DateTimeKind.Utc).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 980, DateTimeKind.Utc).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 980, DateTimeKind.Utc).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 980, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 980, DateTimeKind.Utc).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 980, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 980, DateTimeKind.Utc).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 980, DateTimeKind.Utc).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 980, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 980, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 980, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 980, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 980, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 982, DateTimeKind.Utc).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 982, DateTimeKind.Utc).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 982, DateTimeKind.Utc).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 995, DateTimeKind.Utc).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 995, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 995, DateTimeKind.Utc).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 995, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 995, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 995, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 995, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 995, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 995, DateTimeKind.Utc).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 995, DateTimeKind.Utc).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 995, DateTimeKind.Utc).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 995, DateTimeKind.Utc).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 995, DateTimeKind.Utc).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 995, DateTimeKind.Utc).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 995, DateTimeKind.Utc).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 995, DateTimeKind.Utc).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 995, DateTimeKind.Utc).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 21, 995, DateTimeKind.Utc).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 22, 1, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 22, 1, DateTimeKind.Utc).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 11, 19, 22, 1, DateTimeKind.Utc).AddTicks(4521));

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerOwnedShortProperties_ShortProperties_ShortPropertyId",
                table: "CustomerOwnedShortProperties",
                column: "ShortPropertyId",
                principalTable: "ShortProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
