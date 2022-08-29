using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyMvc.Migrations
{
    public partial class DemandeDeCongé : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DemandeDeCongéId",
                table: "Employee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdDemandeDeCongé",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SoldeDeCongé",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DemandeDeCongé",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateDebut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateRetour = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeDeCongé = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cause = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreJours = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemandeDeCongé", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DemandeDeCongéId",
                table: "Employee",
                column: "DemandeDeCongéId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_DemandeDeCongé_DemandeDeCongéId",
                table: "Employee",
                column: "DemandeDeCongéId",
                principalTable: "DemandeDeCongé",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_DemandeDeCongé_DemandeDeCongéId",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "DemandeDeCongé");

            migrationBuilder.DropIndex(
                name: "IX_Employee_DemandeDeCongéId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DemandeDeCongéId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "IdDemandeDeCongé",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "SoldeDeCongé",
                table: "Employee");
        }
    }
}
