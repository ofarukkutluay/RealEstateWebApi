using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateWebApi.Persistence.Migrations
{
    public partial class mig_12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "UsingStatuses",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "UserOperationClaims",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "UserLogins",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ShortProperties",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PropertyTypes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PropertyStatuses",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Properties",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "OperationClaims",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Messages",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "JobTitles",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "InternetTypes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "HeatingTypes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Fronts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Files",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "EntryTypes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "EntrySubTypes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Entries",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "DeedStatuses",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CustomerSearchShortProperties",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Customers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "EjLink",
                table: "CustomerOwnedShortProperties",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeLink",
                table: "CustomerOwnedShortProperties",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CustomerOwnedShortProperties",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "OtherLink",
                table: "CustomerOwnedShortProperties",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShLink",
                table: "CustomerOwnedShortProperties",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Companies",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Clients",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "BlogTypes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Blogs",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Agents",
                type: "boolean",
                nullable: false,
                defaultValue: false);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "UsingStatuses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "UserOperationClaims");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "UserLogins");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ShortProperties");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PropertyTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PropertyStatuses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "OperationClaims");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "JobTitles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "InternetTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "HeatingTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Fronts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "EntryTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "EntrySubTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Entries");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "DeedStatuses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CustomerSearchShortProperties");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "EjLink",
                table: "CustomerOwnedShortProperties");

            migrationBuilder.DropColumn(
                name: "HeLink",
                table: "CustomerOwnedShortProperties");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CustomerOwnedShortProperties");

            migrationBuilder.DropColumn(
                name: "OtherLink",
                table: "CustomerOwnedShortProperties");

            migrationBuilder.DropColumn(
                name: "ShLink",
                table: "CustomerOwnedShortProperties");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "BlogTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Agents");

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 362, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 362, DateTimeKind.Utc).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 362, DateTimeKind.Utc).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 362, DateTimeKind.Utc).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 365, DateTimeKind.Utc).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 367, DateTimeKind.Utc).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 367, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 367, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 379, DateTimeKind.Utc).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 384, DateTimeKind.Utc).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 384, DateTimeKind.Utc).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 3, 19, 30, 21, 384, DateTimeKind.Utc).AddTicks(3334));
        }
    }
}
