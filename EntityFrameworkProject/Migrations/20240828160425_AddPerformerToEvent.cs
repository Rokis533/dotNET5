using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkProject.Migrations
{
    /// <inheritdoc />
    public partial class AddPerformerToEvent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PerformerId",
                table: "Events",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Events_PerformerId",
                table: "Events",
                column: "PerformerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Performers_PerformerId",
                table: "Events",
                column: "PerformerId",
                principalTable: "Performers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Performers_PerformerId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_PerformerId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "PerformerId",
                table: "Events");
        }
    }
}
