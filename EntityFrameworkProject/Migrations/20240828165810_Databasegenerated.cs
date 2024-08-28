using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkProject.Migrations
{
    /// <inheritdoc />
    public partial class Databasegenerated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tables_Performers_PerformerId",
                table: "tables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tables",
                table: "tables");

            migrationBuilder.RenameTable(
                name: "tables",
                newName: "Events");

            migrationBuilder.RenameIndex(
                name: "IX_tables_PerformerId",
                table: "Events",
                newName: "IX_Events_PerformerId");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Performers_PerformerId",
                table: "Events",
                column: "PerformerId",
                principalTable: "Performers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Performers_PerformerId",
                table: "Events");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Events");

            migrationBuilder.RenameTable(
                name: "Events",
                newName: "tables");

            migrationBuilder.RenameIndex(
                name: "IX_Events_PerformerId",
                table: "tables",
                newName: "IX_tables_PerformerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tables",
                table: "tables",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tables_Performers_PerformerId",
                table: "tables",
                column: "PerformerId",
                principalTable: "Performers",
                principalColumn: "Id");
        }
    }
}
