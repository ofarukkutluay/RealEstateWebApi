using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RealEstateWebApi.Persistence.Migrations
{
    public partial class mig_14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerOwnedShortProperties_ShortProperties_ShortPropertyId",
                table: "CustomerOwnedShortProperties");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerSearchShortProperties_ShortProperties_ShortProperty~",
                table: "CustomerSearchShortProperties");

            migrationBuilder.DropTable(
                name: "ShortProperties");

            migrationBuilder.DropIndex(
                name: "IX_CustomerSearchShortProperties_ShortPropertyId",
                table: "CustomerSearchShortProperties");

            migrationBuilder.DropIndex(
                name: "IX_CustomerOwnedShortProperties_ShortPropertyId",
                table: "CustomerOwnedShortProperties");

            migrationBuilder.DropColumn(
                name: "ShortPropertyId",
                table: "CustomerSearchShortProperties");

            migrationBuilder.DropColumn(
                name: "ShortPropertyId",
                table: "CustomerOwnedShortProperties");

            migrationBuilder.AddColumn<long>(
                name: "PropertyId",
                table: "CustomerSearchShortProperties",
                type: "bigint",
                nullable: true);

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
                name: "IX_CustomerSearchShortProperties_PropertyId",
                table: "CustomerSearchShortProperties",
                column: "PropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerSearchShortProperties_Properties_PropertyId",
                table: "CustomerSearchShortProperties",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerSearchShortProperties_Properties_PropertyId",
                table: "CustomerSearchShortProperties");

            migrationBuilder.DropIndex(
                name: "IX_CustomerSearchShortProperties_PropertyId",
                table: "CustomerSearchShortProperties");

            migrationBuilder.DropColumn(
                name: "PropertyId",
                table: "CustomerSearchShortProperties");

            migrationBuilder.AddColumn<long>(
                name: "ShortPropertyId",
                table: "CustomerSearchShortProperties",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ShortPropertyId",
                table: "CustomerOwnedShortProperties",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ShortProperties",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CityId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    LivingRoomCount = table.Column<int>(type: "integer", nullable: true),
                    NeighborhoodId = table.Column<long>(type: "bigint", nullable: true),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    PropertyStatusId = table.Column<long>(type: "bigint", nullable: false),
                    PropertyTypeId = table.Column<long>(type: "bigint", nullable: false),
                    RoomCount = table.Column<int>(type: "integer", nullable: true),
                    StreetId = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShortProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShortProperties_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShortProperties_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShortProperties_Neighborhoods_NeighborhoodId",
                        column: x => x.NeighborhoodId,
                        principalTable: "Neighborhoods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ShortProperties_PropertyStatuses_PropertyStatusId",
                        column: x => x.PropertyStatusId,
                        principalTable: "PropertyStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShortProperties_PropertyTypes_PropertyTypeId",
                        column: x => x.PropertyTypeId,
                        principalTable: "PropertyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShortProperties_Streets_StreetId",
                        column: x => x.StreetId,
                        principalTable: "Streets",
                        principalColumn: "Id");
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
                name: "IX_CustomerSearchShortProperties_ShortPropertyId",
                table: "CustomerSearchShortProperties",
                column: "ShortPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOwnedShortProperties_ShortPropertyId",
                table: "CustomerOwnedShortProperties",
                column: "ShortPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_ShortProperties_CityId",
                table: "ShortProperties",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_ShortProperties_DistrictId",
                table: "ShortProperties",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_ShortProperties_NeighborhoodId",
                table: "ShortProperties",
                column: "NeighborhoodId");

            migrationBuilder.CreateIndex(
                name: "IX_ShortProperties_PropertyStatusId",
                table: "ShortProperties",
                column: "PropertyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ShortProperties_PropertyTypeId",
                table: "ShortProperties",
                column: "PropertyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ShortProperties_StreetId",
                table: "ShortProperties",
                column: "StreetId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerOwnedShortProperties_ShortProperties_ShortPropertyId",
                table: "CustomerOwnedShortProperties",
                column: "ShortPropertyId",
                principalTable: "ShortProperties",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerSearchShortProperties_ShortProperties_ShortProperty~",
                table: "CustomerSearchShortProperties",
                column: "ShortPropertyId",
                principalTable: "ShortProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
