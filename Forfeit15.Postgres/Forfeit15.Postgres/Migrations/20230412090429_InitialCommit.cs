using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forfeit15.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class InitialCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PatchNotes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatchNotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InfoNodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PatchNoteId = table.Column<Guid>(type: "uuid", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    Text = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NodeType = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoNodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InfoNodes_PatchNotes_Id",
                        column: x => x.Id,
                        principalTable: "PatchNotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InfoNodes_PatchNotes_PatchNoteId",
                        column: x => x.PatchNoteId,
                        principalTable: "PatchNotes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_InfoNodes_PatchNoteId",
                table: "InfoNodes",
                column: "PatchNoteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InfoNodes");

            migrationBuilder.DropTable(
                name: "PatchNotes");
        }
    }
}
