using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RealEstateWebApi.Persistence.Migrations
{
    public partial class mig_15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerOwnedShortProperties");

            migrationBuilder.DropTable(
                name: "CustomerSearchShortProperties");

            migrationBuilder.CreateTable(
                name: "CustomerOwnedProperties",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    PropertyId = table.Column<long>(type: "bigint", nullable: true),
                    PropertyListingDetailId = table.Column<long>(type: "bigint", nullable: true),
                    PropertyTypeId = table.Column<long>(type: "bigint", nullable: false),
                    PropertyStatusId = table.Column<long>(type: "bigint", nullable: false),
                    RoomCount = table.Column<int>(type: "integer", nullable: true),
                    LivingRoomCount = table.Column<int>(type: "integer", nullable: true),
                    CityId = table.Column<long>(type: "bigint", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    NeighborhoodId = table.Column<long>(type: "bigint", nullable: true),
                    StreetId = table.Column<long>(type: "bigint", nullable: true),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ShLink = table.Column<string>(type: "text", nullable: true),
                    EjLink = table.Column<string>(type: "text", nullable: true),
                    HeLink = table.Column<string>(type: "text", nullable: true),
                    OtherLink = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerOwnedProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerOwnedProperties_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerOwnedProperties_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomerOwnedProperties_PropertyListingDetails_PropertyList~",
                        column: x => x.PropertyListingDetailId,
                        principalTable: "PropertyListingDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerSearchProperties",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    PropertyTypeId = table.Column<long>(type: "bigint", nullable: false),
                    PropertyStatusId = table.Column<long>(type: "bigint", nullable: false),
                    RoomCount = table.Column<int>(type: "integer", nullable: true),
                    LivingRoomCount = table.Column<int>(type: "integer", nullable: true),
                    CityId = table.Column<long>(type: "bigint", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    NeighborhoodId = table.Column<long>(type: "bigint", nullable: true),
                    StreetId = table.Column<long>(type: "bigint", nullable: true),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerSearchProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerSearchProperties_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOwnedProperties_CustomerId",
                table: "CustomerOwnedProperties",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOwnedProperties_PropertyId",
                table: "CustomerOwnedProperties",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOwnedProperties_PropertyListingDetailId",
                table: "CustomerOwnedProperties",
                column: "PropertyListingDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSearchProperties_CustomerId",
                table: "CustomerSearchProperties",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerOwnedProperties");

            migrationBuilder.DropTable(
                name: "CustomerSearchProperties");

            migrationBuilder.CreateTable(
                name: "CustomerOwnedShortProperties",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    EjLink = table.Column<string>(type: "text", nullable: true),
                    HeLink = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    OtherLink = table.Column<string>(type: "text", nullable: true),
                    PropertyId = table.Column<long>(type: "bigint", nullable: true),
                    PropertyListingDetailId = table.Column<long>(type: "bigint", nullable: true),
                    ShLink = table.Column<string>(type: "text", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerOwnedShortProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerOwnedShortProperties_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerOwnedShortProperties_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomerOwnedShortProperties_PropertyListingDetails_Propert~",
                        column: x => x.PropertyListingDetailId,
                        principalTable: "PropertyListingDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerSearchShortProperties",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    PropertyId = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerSearchShortProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerSearchShortProperties_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerSearchShortProperties_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 914, DateTimeKind.Utc).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 914, DateTimeKind.Utc).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 914, DateTimeKind.Utc).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 914, DateTimeKind.Utc).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 916, DateTimeKind.Utc).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 916, DateTimeKind.Utc).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 916, DateTimeKind.Utc).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 916, DateTimeKind.Utc).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 916, DateTimeKind.Utc).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 916, DateTimeKind.Utc).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 916, DateTimeKind.Utc).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 916, DateTimeKind.Utc).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 916, DateTimeKind.Utc).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 916, DateTimeKind.Utc).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 916, DateTimeKind.Utc).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 916, DateTimeKind.Utc).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 916, DateTimeKind.Utc).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 916, DateTimeKind.Utc).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 916, DateTimeKind.Utc).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 916, DateTimeKind.Utc).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 916, DateTimeKind.Utc).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 916, DateTimeKind.Utc).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 916, DateTimeKind.Utc).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 916, DateTimeKind.Utc).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 916, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 917, DateTimeKind.Utc).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 917, DateTimeKind.Utc).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 917, DateTimeKind.Utc).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 924, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 924, DateTimeKind.Utc).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 924, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 924, DateTimeKind.Utc).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 924, DateTimeKind.Utc).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 924, DateTimeKind.Utc).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 924, DateTimeKind.Utc).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 924, DateTimeKind.Utc).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 924, DateTimeKind.Utc).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 924, DateTimeKind.Utc).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 924, DateTimeKind.Utc).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 924, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 924, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 924, DateTimeKind.Utc).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 924, DateTimeKind.Utc).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 924, DateTimeKind.Utc).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 924, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 924, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 925, DateTimeKind.Utc).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 925, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 22, 59, 33, 925, DateTimeKind.Utc).AddTicks(8293));

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOwnedShortProperties_CustomerId",
                table: "CustomerOwnedShortProperties",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOwnedShortProperties_PropertyId",
                table: "CustomerOwnedShortProperties",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOwnedShortProperties_PropertyListingDetailId",
                table: "CustomerOwnedShortProperties",
                column: "PropertyListingDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSearchShortProperties_CustomerId",
                table: "CustomerSearchShortProperties",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSearchShortProperties_PropertyId",
                table: "CustomerSearchShortProperties",
                column: "PropertyId");
        }
    }
}
