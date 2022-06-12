using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateWebApi.Persistence.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ClientId",
                table: "UsingStatuses",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ClientId",
                table: "PropertyStatuses",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ClientId",
                table: "Properties",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CompanyId",
                table: "Properties",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ClientId",
                table: "Messages",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ClientId",
                table: "JobTitles",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CompanyId",
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
                table: "Blogs",
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
                name: "IX_Properties_ClientId",
                table: "Properties",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_CompanyId",
                table: "Properties",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ClientId",
                table: "Messages",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitles_ClientId",
                table: "JobTitles",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitles_CompanyId",
                table: "JobTitles",
                column: "CompanyId");

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
                name: "IX_Blogs_ClientId",
                table: "Blogs",
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
                name: "FK_Blogs_Clients_ClientId",
                table: "Blogs",
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
                name: "FK_JobTitles_Companies_CompanyId",
                table: "JobTitles",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Clients_ClientId",
                table: "Messages",
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
                name: "FK_Properties_Companies_CompanyId",
                table: "Properties",
                column: "CompanyId",
                principalTable: "Companies",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agents_Clients_ClientId",
                table: "Agents");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Clients_ClientId",
                table: "Blogs");

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
                name: "FK_JobTitles_Companies_CompanyId",
                table: "JobTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Clients_ClientId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Clients_ClientId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Companies_CompanyId",
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
                name: "IX_Properties_ClientId",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_CompanyId",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ClientId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_JobTitles_ClientId",
                table: "JobTitles");

            migrationBuilder.DropIndex(
                name: "IX_JobTitles_CompanyId",
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
                name: "IX_Blogs_ClientId",
                table: "Blogs");

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
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "JobTitles");

            migrationBuilder.DropColumn(
                name: "CompanyId",
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
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Agents");
        }
    }
}
