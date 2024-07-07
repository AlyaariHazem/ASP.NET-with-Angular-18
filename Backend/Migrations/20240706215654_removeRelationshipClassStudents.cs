using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class removeRelationshipClassStudents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classes_StudentID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ClassID",
                table: "Students");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassID",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classes_StudentID",
                table: "Students",
                column: "StudentID",
                principalTable: "Classes",
                principalColumn: "ClassID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
