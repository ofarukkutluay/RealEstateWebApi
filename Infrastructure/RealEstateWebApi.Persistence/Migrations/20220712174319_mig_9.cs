using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RealEstateWebApi.Persistence.Migrations
{
    public partial class mig_9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Streets_CityId",
                table: "Properties");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    MobileNumber = table.Column<string>(type: "text", nullable: false),
                    MobileNumber2 = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber2 = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    CityId = table.Column<long>(type: "bigint", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    NeighborhoodId = table.Column<long>(type: "bigint", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CitizenNumber = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_Neighborhoods_NeighborhoodId",
                        column: x => x.NeighborhoodId,
                        principalTable: "Neighborhoods",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EntryTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntryTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShortProperties",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PropertyTypeId = table.Column<long>(type: "bigint", nullable: false),
                    PropertyStatusId = table.Column<long>(type: "bigint", nullable: false),
                    RoomCount = table.Column<int>(type: "integer", nullable: true),
                    LivingRoomCount = table.Column<int>(type: "integer", nullable: true),
                    CityId = table.Column<long>(type: "bigint", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    NeighborhoodId = table.Column<long>(type: "bigint", nullable: false),
                    StreetId = table.Column<long>(type: "bigint", nullable: true),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "EntrySubTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EntryTypeId = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntrySubTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntrySubTypes_EntryTypes_EntryTypeId",
                        column: x => x.EntryTypeId,
                        principalTable: "EntryTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerOwnedShortProperties",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    ShortPropertyId = table.Column<long>(type: "bigint", nullable: false),
                    PropertyId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
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
                        name: "FK_CustomerOwnedShortProperties_ShortProperties_ShortPropertyId",
                        column: x => x.ShortPropertyId,
                        principalTable: "ShortProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerSearchShortProperties",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    ShortPropertyId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
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
                        name: "FK_CustomerSearchShortProperties_ShortProperties_ShortProperty~",
                        column: x => x.ShortPropertyId,
                        principalTable: "ShortProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: false),
                    EntryTypeId = table.Column<long>(type: "bigint", nullable: false),
                    EntrySubTypeId = table.Column<long>(type: "bigint", nullable: true),
                    EntrySubTitle = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entries_EntrySubTypes_EntrySubTypeId",
                        column: x => x.EntrySubTypeId,
                        principalTable: "EntrySubTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Entries_EntryTypes_EntryTypeId",
                        column: x => x.EntryTypeId,
                        principalTable: "EntryTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entries_Users_UserId",
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
                value: new DateTime(2022, 7, 12, 17, 43, 18, 592, DateTimeKind.Utc).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 592, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 592, DateTimeKind.Utc).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 592, DateTimeKind.Utc).AddTicks(9442));

            migrationBuilder.InsertData(
                table: "EntryTypes",
                columns: new[] { "Id", "CreatedDate", "IsActive", "Title", "UpdatedDate" },
                values: new object[] { 1L, new DateTime(2022, 7, 12, 17, 43, 18, 594, DateTimeKind.Utc).AddTicks(3739), true, "Görüşme", null });

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 594, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 594, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 594, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 594, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 594, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 594, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 594, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 594, DateTimeKind.Utc).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 594, DateTimeKind.Utc).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 594, DateTimeKind.Utc).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 594, DateTimeKind.Utc).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 594, DateTimeKind.Utc).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 594, DateTimeKind.Utc).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 594, DateTimeKind.Utc).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 594, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 594, DateTimeKind.Utc).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 594, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 594, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 595, DateTimeKind.Utc).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 595, DateTimeKind.Utc).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 595, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 603, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 603, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 603, DateTimeKind.Utc).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 603, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 603, DateTimeKind.Utc).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 604, DateTimeKind.Utc).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 604, DateTimeKind.Utc).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 604, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 604, DateTimeKind.Utc).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 604, DateTimeKind.Utc).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 604, DateTimeKind.Utc).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 604, DateTimeKind.Utc).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 604, DateTimeKind.Utc).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 604, DateTimeKind.Utc).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 604, DateTimeKind.Utc).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 604, DateTimeKind.Utc).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 604, DateTimeKind.Utc).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 604, DateTimeKind.Utc).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 609, DateTimeKind.Utc).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 609, DateTimeKind.Utc).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 609, DateTimeKind.Utc).AddTicks(1012));

            migrationBuilder.InsertData(
                table: "EntrySubTypes",
                columns: new[] { "Id", "CreatedDate", "EntryTypeId", "IsActive", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 7, 12, 17, 43, 18, 594, DateTimeKind.Utc).AddTicks(3239), 1L, true, "Ziyaret", null },
                    { 2L, new DateTime(2022, 7, 12, 17, 43, 18, 594, DateTimeKind.Utc).AddTicks(3241), 1L, true, "Telefon", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Properties_StreetId",
                table: "Properties",
                column: "StreetId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOwnedShortProperties_CustomerId",
                table: "CustomerOwnedShortProperties",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOwnedShortProperties_PropertyId",
                table: "CustomerOwnedShortProperties",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOwnedShortProperties_ShortPropertyId",
                table: "CustomerOwnedShortProperties",
                column: "ShortPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CityId",
                table: "Customers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_DistrictId",
                table: "Customers",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_NeighborhoodId",
                table: "Customers",
                column: "NeighborhoodId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSearchShortProperties_CustomerId",
                table: "CustomerSearchShortProperties",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSearchShortProperties_ShortPropertyId",
                table: "CustomerSearchShortProperties",
                column: "ShortPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Entries_EntrySubTypeId",
                table: "Entries",
                column: "EntrySubTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Entries_EntryTypeId",
                table: "Entries",
                column: "EntryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Entries_UserId",
                table: "Entries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EntrySubTypes_EntryTypeId",
                table: "EntrySubTypes",
                column: "EntryTypeId");

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
                name: "FK_Properties_Streets_StreetId",
                table: "Properties",
                column: "StreetId",
                principalTable: "Streets",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Streets_StreetId",
                table: "Properties");

            migrationBuilder.DropTable(
                name: "CustomerOwnedShortProperties");

            migrationBuilder.DropTable(
                name: "CustomerSearchShortProperties");

            migrationBuilder.DropTable(
                name: "Entries");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ShortProperties");

            migrationBuilder.DropTable(
                name: "EntrySubTypes");

            migrationBuilder.DropTable(
                name: "EntryTypes");

            migrationBuilder.DropIndex(
                name: "IX_Properties_StreetId",
                table: "Properties");

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 546, DateTimeKind.Utc).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 548, DateTimeKind.Utc).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 548, DateTimeKind.Utc).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 548, DateTimeKind.Utc).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 560, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 561, DateTimeKind.Utc).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 561, DateTimeKind.Utc).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 10, 19, 15, 11, 561, DateTimeKind.Utc).AddTicks(9883));

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Streets_CityId",
                table: "Properties",
                column: "CityId",
                principalTable: "Streets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
