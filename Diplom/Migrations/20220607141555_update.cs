using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Diplom.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PortfolioId",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PortfolioId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);
        }
    }
}
