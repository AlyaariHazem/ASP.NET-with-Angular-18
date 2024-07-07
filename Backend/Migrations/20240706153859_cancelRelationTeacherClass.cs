using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class cancelRelationTeacherClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Classes_ClassID",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_ClassID",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "ClassID",
                table: "Teachers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassID",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_ClassID",
                table: "Teachers",
                column: "ClassID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Classes_ClassID",
                table: "Teachers",
                column: "ClassID",
                principalTable: "Classes",
                principalColumn: "ClassID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
