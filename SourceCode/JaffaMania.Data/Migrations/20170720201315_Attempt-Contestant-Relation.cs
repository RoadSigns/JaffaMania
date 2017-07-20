using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JaffaMania.Data.Migrations
{
    public partial class AttemptContestantRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attempt_Contestant_ContestantDtoId",
                table: "Attempt");

            migrationBuilder.RenameColumn(
                name: "ContestantDtoId",
                table: "Attempt",
                newName: "ContestantId");

            migrationBuilder.RenameIndex(
                name: "IX_Attempt_ContestantDtoId",
                table: "Attempt",
                newName: "IX_Attempt_ContestantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attempt_Contestant_ContestantId",
                table: "Attempt",
                column: "ContestantId",
                principalTable: "Contestant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attempt_Contestant_ContestantId",
                table: "Attempt");

            migrationBuilder.RenameColumn(
                name: "ContestantId",
                table: "Attempt",
                newName: "ContestantDtoId");

            migrationBuilder.RenameIndex(
                name: "IX_Attempt_ContestantId",
                table: "Attempt",
                newName: "IX_Attempt_ContestantDtoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attempt_Contestant_ContestantDtoId",
                table: "Attempt",
                column: "ContestantDtoId",
                principalTable: "Contestant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
