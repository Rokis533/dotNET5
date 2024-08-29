using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkProject.Migrations
{
    /// <inheritdoc />
    public partial class AddedConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Performers_PerformerId",
                table: "Events");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Performers",
                table: "Performers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

            migrationBuilder.RenameTable(
                name: "Performers",
                newName: "performerTable");

            migrationBuilder.RenameTable(
                name: "Events",
                newName: "eventTable");

            migrationBuilder.RenameIndex(
                name: "IX_Events_PerformerId",
                table: "eventTable",
                newName: "IX_eventTable_PerformerId");

            migrationBuilder.AlterColumn<string>(
                name: "Types",
                table: "performerTable",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "performerTable",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "eventTable",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddPrimaryKey(
                name: "PK_performerTable",
                table: "performerTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_eventTable",
                table: "eventTable",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_eventTable_performerTable_PerformerId",
                table: "eventTable",
                column: "PerformerId",
                principalTable: "performerTable",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_eventTable_performerTable_PerformerId",
                table: "eventTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_performerTable",
                table: "performerTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_eventTable",
                table: "eventTable");

            migrationBuilder.RenameTable(
                name: "performerTable",
                newName: "Performers");

            migrationBuilder.RenameTable(
                name: "eventTable",
                newName: "Events");

            migrationBuilder.RenameIndex(
                name: "IX_eventTable_PerformerId",
                table: "Events",
                newName: "IX_Events_PerformerId");

            migrationBuilder.AlterColumn<string>(
                name: "Types",
                table: "Performers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Performers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Events",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Performers",
                table: "Performers",
                column: "Id");

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
    }
}
