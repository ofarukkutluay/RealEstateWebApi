using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateWebApi.Persistence.Migrations
{
    public partial class mig_7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agents_Clients_ClientId",
                table: "Agents");

            migrationBuilder.DropForeignKey(
                name: "FK_DeedStatuses_Clients_ClientId",
                table: "DeedStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_Fronts_Clients_ClientId",
                table: "Fronts");

            migrationBuilder.DropForeignKey(
                name: "FK_HeatingTypes_Clients_ClientId",
                table: "HeatingTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_InternetTypes_Clients_ClientId",
                table: "InternetTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTitles_Clients_ClientId",
                table: "JobTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Clients_ClientId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyStatuses_Clients_ClientId",
                table: "PropertyStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_UsingStatuses_Clients_ClientId",
                table: "UsingStatuses");

            migrationBuilder.DropIndex(
                name: "IX_UsingStatuses_ClientId",
                table: "UsingStatuses");

            migrationBuilder.DropIndex(
                name: "IX_PropertyStatuses_ClientId",
                table: "PropertyStatuses");

            migrationBuilder.DropIndex(
                name: "IX_JobTitles_ClientId",
                table: "JobTitles");

            migrationBuilder.DropIndex(
                name: "IX_InternetTypes_ClientId",
                table: "InternetTypes");

            migrationBuilder.DropIndex(
                name: "IX_HeatingTypes_ClientId",
                table: "HeatingTypes");

            migrationBuilder.DropIndex(
                name: "IX_Fronts_ClientId",
                table: "Fronts");

            migrationBuilder.DropIndex(
                name: "IX_DeedStatuses_ClientId",
                table: "DeedStatuses");

            migrationBuilder.DropIndex(
                name: "IX_Agents_ClientId",
                table: "Agents");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "UsingStatuses");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "PropertyStatuses");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "JobTitles");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "InternetTypes");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "HeatingTypes");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Fronts");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "DeedStatuses");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Agents");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Users",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ClientId",
                table: "Properties",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "ClientId",
                table: "BlogTypes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_BlogTypes_ClientId",
                table: "BlogTypes",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogTypes_Clients_ClientId",
                table: "BlogTypes",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Clients_ClientId",
                table: "Properties",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogTypes_Clients_ClientId",
                table: "BlogTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Clients_ClientId",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_BlogTypes_ClientId",
                table: "BlogTypes");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "BlogTypes");

            migrationBuilder.AddColumn<long>(
                name: "ClientId",
                table: "UsingStatuses",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "BirthDate",
                table: "Users",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ClientId",
                table: "PropertyStatuses",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<long>(
                name: "ClientId",
                table: "Properties",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ClientId",
                table: "JobTitles",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ClientId",
                table: "InternetTypes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ClientId",
                table: "HeatingTypes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ClientId",
                table: "Fronts",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ClientId",
                table: "DeedStatuses",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ClientId",
                table: "Agents",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_UsingStatuses_ClientId",
                table: "UsingStatuses",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyStatuses_ClientId",
                table: "PropertyStatuses",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitles_ClientId",
                table: "JobTitles",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_InternetTypes_ClientId",
                table: "InternetTypes",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_HeatingTypes_ClientId",
                table: "HeatingTypes",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Fronts_ClientId",
                table: "Fronts",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_DeedStatuses_ClientId",
                table: "DeedStatuses",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Agents_ClientId",
                table: "Agents",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agents_Clients_ClientId",
                table: "Agents",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeedStatuses_Clients_ClientId",
                table: "DeedStatuses",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fronts_Clients_ClientId",
                table: "Fronts",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HeatingTypes_Clients_ClientId",
                table: "HeatingTypes",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InternetTypes_Clients_ClientId",
                table: "InternetTypes",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTitles_Clients_ClientId",
                table: "JobTitles",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Clients_ClientId",
                table: "Properties",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyStatuses_Clients_ClientId",
                table: "PropertyStatuses",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsingStatuses_Clients_ClientId",
                table: "UsingStatuses",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
