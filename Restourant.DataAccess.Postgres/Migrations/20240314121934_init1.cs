using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restourant.DataAccess.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Checks_Check1Id",
                table: "Dishes");

            migrationBuilder.DropIndex(
                name: "IX_Dishes_Check1Id",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "Check1Id",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "CheckId",
                table: "Dishes");

            migrationBuilder.CreateIndex(
                name: "IX_Checks_DishId",
                table: "Checks",
                column: "DishId");

            migrationBuilder.AddForeignKey(
                name: "FK_Checks_Dishes_DishId",
                table: "Checks",
                column: "DishId",
                principalTable: "Dishes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checks_Dishes_DishId",
                table: "Checks");

            migrationBuilder.DropIndex(
                name: "IX_Checks_DishId",
                table: "Checks");

            migrationBuilder.AddColumn<int>(
                name: "Check1Id",
                table: "Dishes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CheckId",
                table: "Dishes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_Check1Id",
                table: "Dishes",
                column: "Check1Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Checks_Check1Id",
                table: "Dishes",
                column: "Check1Id",
                principalTable: "Checks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
