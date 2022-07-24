using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateWebApi.Persistence.Migrations
{
    public partial class mig_10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entries_EntrySubTypes_EntrySubTypeId",
                table: "Entries");

            migrationBuilder.DropForeignKey(
                name: "FK_ShortProperties_Neighborhoods_NeighborhoodId",
                table: "ShortProperties");

            migrationBuilder.AlterColumn<long>(
                name: "NeighborhoodId",
                table: "ShortProperties",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "EntrySubTypeId",
                table: "Entries",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CustomerId",
                table: "Entries",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "AssignedUserId",
                table: "Customers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "RegisterUserId",
                table: "Customers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 873, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 873, DateTimeKind.Utc).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 873, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "DeedStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 873, DateTimeKind.Utc).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Fronts",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "HeatingTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "InternetTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 874, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 875, DateTimeKind.Utc).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 875, DateTimeKind.Utc).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 875, DateTimeKind.Utc).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 881, DateTimeKind.Utc).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 884, DateTimeKind.Utc).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 884, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "UsingStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 24, 13, 51, 9, 884, DateTimeKind.Utc).AddTicks(5389));

            migrationBuilder.CreateIndex(
                name: "IX_Entries_CustomerId",
                table: "Entries",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entries_Customers_CustomerId",
                table: "Entries",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entries_EntrySubTypes_EntrySubTypeId",
                table: "Entries",
                column: "EntrySubTypeId",
                principalTable: "EntrySubTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShortProperties_Neighborhoods_NeighborhoodId",
                table: "ShortProperties",
                column: "NeighborhoodId",
                principalTable: "Neighborhoods",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entries_Customers_CustomerId",
                table: "Entries");

            migrationBuilder.DropForeignKey(
                name: "FK_Entries_EntrySubTypes_EntrySubTypeId",
                table: "Entries");

            migrationBuilder.DropForeignKey(
                name: "FK_ShortProperties_Neighborhoods_NeighborhoodId",
                table: "ShortProperties");

            migrationBuilder.DropIndex(
                name: "IX_Entries_CustomerId",
                table: "Entries");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Entries");

            migrationBuilder.DropColumn(
                name: "AssignedUserId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "RegisterUserId",
                table: "Customers");

            migrationBuilder.AlterColumn<long>(
                name: "NeighborhoodId",
                table: "ShortProperties",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "EntrySubTypeId",
                table: "Entries",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

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

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 594, DateTimeKind.Utc).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "EntrySubTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 594, DateTimeKind.Utc).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "EntryTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 12, 17, 43, 18, 594, DateTimeKind.Utc).AddTicks(3739));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Entries_EntrySubTypes_EntrySubTypeId",
                table: "Entries",
                column: "EntrySubTypeId",
                principalTable: "EntrySubTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShortProperties_Neighborhoods_NeighborhoodId",
                table: "ShortProperties",
                column: "NeighborhoodId",
                principalTable: "Neighborhoods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
