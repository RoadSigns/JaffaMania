using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JaffaMania.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contestant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FamilyName = table.Column<string>(nullable: true),
                    GivenName = table.Column<string>(nullable: true),
                    PublicId = table.Column<string>(nullable: true),
                    StageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contestant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attempt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContestantDtoId = table.Column<int>(nullable: true),
                    HappenedOn = table.Column<DateTime>(nullable: false),
                    PublicId = table.Column<string>(nullable: true),
                    TimeTaken = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attempt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attempt_Contestant_ContestantDtoId",
                        column: x => x.ContestantDtoId,
                        principalTable: "Contestant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attempt_ContestantDtoId",
                table: "Attempt",
                column: "ContestantDtoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attempt");

            migrationBuilder.DropTable(
                name: "Contestant");
        }
    }
}
