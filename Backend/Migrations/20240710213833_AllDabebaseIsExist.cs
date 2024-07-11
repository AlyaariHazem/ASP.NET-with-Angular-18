using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class AllDabebaseIsExist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Schools_SchoolID",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Appreciation",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DivisionName",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Teachers",
                newName: "FullName_LastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Teachers",
                newName: "FullName_FirstName");

            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "Teachers",
                newName: "FullName_ThirdName");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Students",
                newName: "FullName_LastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Students",
                newName: "FullName_FirstName");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Students",
                newName: "FullName_ThirdName");

            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "Students",
                newName: "FullName_SecondName");

            migrationBuilder.RenameColumn(
                name: "Grade",
                table: "Students",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "SchoolLocation",
                table: "Schools",
                newName: "zone");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Managers",
                newName: "FullName_LastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Managers",
                newName: "FullName_FirstName");

            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "Managers",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Guardians",
                newName: "FullName_LastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Guardians",
                newName: "FullName_FirstName");

            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "Guardians",
                newName: "FullName_ThirdName");

            migrationBuilder.RenameColumn(
                name: "SchoolID",
                table: "Classes",
                newName: "PhaseID");

            migrationBuilder.RenameIndex(
                name: "IX_Classes_SchoolID",
                table: "Classes",
                newName: "IX_Classes_PhaseID");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName_SecondName",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "Students",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "Students",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SchoolGoal",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SchoolMission",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SchoolNameEn",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SchoolPhone",
                table: "Schools",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SchoolType",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SchoolVison",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "School_Crea_Date",
                table: "Schools",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "fax",
                table: "Schools",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Managers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Managers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName_SecondName",
                table: "Managers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName_ThirdName",
                table: "Managers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Managers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "TypeGuardian",
                table: "Guardians",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "Guardians",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Job",
                table: "Guardians",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Guardians",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Guardians",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName_SecondName",
                table: "Guardians",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Guardians",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Salarys",
                columns: table => new
                {
                    SalaryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalaryMonth = table.Column<DateOnly>(type: "date", nullable: false),
                    SalaryHireDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalaryAmount = table.Column<int>(type: "int", nullable: false),
                    TeacherID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salarys", x => x.SalaryID);
                    table.ForeignKey(
                        name: "FK_Salarys_Teachers_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "Teachers",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentClass",
                columns: table => new
                {
                    ClassID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentClass", x => new { x.StudentID, x.ClassID });
                    table.ForeignKey(
                        name: "FK_StudentClass_Classes_ClassID",
                        column: x => x.ClassID,
                        principalTable: "Classes",
                        principalColumn: "ClassID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentClass_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeacherSubjectStudent",
                columns: table => new
                {
                    TeacherID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    SubjectID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherSubjectStudent", x => new { x.TeacherID, x.StudentID, x.SubjectID });
                    table.ForeignKey(
                        name: "FK_TeacherSubjectStudent_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherSubjectStudent_Subjects_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "Subjects",
                        principalColumn: "SubjectID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherSubjectStudent_Teachers_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "Teachers",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName_SecondName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName_ThirdName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName_LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Year",
                columns: table => new
                {
                    YearID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearDateStart = table.Column<DateOnly>(type: "date", nullable: false),
                    YearDateEnd = table.Column<DateOnly>(type: "date", nullable: false),
                    HireDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    SchoolID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Year", x => x.YearID);
                    table.ForeignKey(
                        name: "FK_Year_Schools_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "Schools",
                        principalColumn: "SchoolID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Phase",
                columns: table => new
                {
                    PhaseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhaseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YearID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phase", x => x.PhaseID);
                    table.ForeignKey(
                        name: "FK_Phase_Year_YearID",
                        column: x => x.YearID,
                        principalTable: "Year",
                        principalColumn: "YearID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserID",
                table: "Teachers",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserID",
                table: "Students",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Managers_UserID",
                table: "Managers",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Guardians_UserID",
                table: "Guardians",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Phase_YearID",
                table: "Phase",
                column: "YearID");

            migrationBuilder.CreateIndex(
                name: "IX_Salarys_TeacherID",
                table: "Salarys",
                column: "TeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClass_ClassID",
                table: "StudentClass",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSubjectStudent_StudentID",
                table: "TeacherSubjectStudent",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSubjectStudent_SubjectID",
                table: "TeacherSubjectStudent",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Year_SchoolID",
                table: "Year",
                column: "SchoolID");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Phase_PhaseID",
                table: "Classes",
                column: "PhaseID",
                principalTable: "Phase",
                principalColumn: "PhaseID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Guardians_Users_UserID",
                table: "Guardians",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Managers_Users_UserID",
                table: "Managers",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Users_UserID",
                table: "Students",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Users_UserID",
                table: "Teachers",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Phase_PhaseID",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Guardians_Users_UserID",
                table: "Guardians");

            migrationBuilder.DropForeignKey(
                name: "FK_Managers_Users_UserID",
                table: "Managers");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Users_UserID",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Users_UserID",
                table: "Teachers");

            migrationBuilder.DropTable(
                name: "Phase");

            migrationBuilder.DropTable(
                name: "Salarys");

            migrationBuilder.DropTable(
                name: "StudentClass");

            migrationBuilder.DropTable(
                name: "TeacherSubjectStudent");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Year");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_UserID",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Students_UserID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Managers_UserID",
                table: "Managers");

            migrationBuilder.DropIndex(
                name: "IX_Guardians_UserID",
                table: "Guardians");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "FullName_SecondName",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "SchoolGoal",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "SchoolMission",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "SchoolNameEn",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "SchoolPhone",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "SchoolType",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "SchoolVison",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "School_Crea_Date",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "fax",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "FullName_SecondName",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "FullName_ThirdName",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Guardians");

            migrationBuilder.DropColumn(
                name: "FullName_SecondName",
                table: "Guardians");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Guardians");

            migrationBuilder.RenameColumn(
                name: "FullName_LastName",
                table: "Teachers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "FullName_FirstName",
                table: "Teachers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "FullName_ThirdName",
                table: "Teachers",
                newName: "MiddleName");

            migrationBuilder.RenameColumn(
                name: "FullName_LastName",
                table: "Students",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "FullName_FirstName",
                table: "Students",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Students",
                newName: "Grade");

            migrationBuilder.RenameColumn(
                name: "FullName_ThirdName",
                table: "Students",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "FullName_SecondName",
                table: "Students",
                newName: "MiddleName");

            migrationBuilder.RenameColumn(
                name: "zone",
                table: "Schools",
                newName: "SchoolLocation");

            migrationBuilder.RenameColumn(
                name: "FullName_LastName",
                table: "Managers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "FullName_FirstName",
                table: "Managers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Managers",
                newName: "MiddleName");

            migrationBuilder.RenameColumn(
                name: "FullName_LastName",
                table: "Guardians",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "FullName_FirstName",
                table: "Guardians",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "FullName_ThirdName",
                table: "Guardians",
                newName: "MiddleName");

            migrationBuilder.RenameColumn(
                name: "PhaseID",
                table: "Classes",
                newName: "SchoolID");

            migrationBuilder.RenameIndex(
                name: "IX_Classes_PhaseID",
                table: "Classes",
                newName: "IX_Classes_SchoolID");

            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "Teachers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Appreciation",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DivisionName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Managers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TypeGuardian",
                table: "Guardians",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Guardians",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Job",
                table: "Guardians",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Guardians",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Schools_SchoolID",
                table: "Classes",
                column: "SchoolID",
                principalTable: "Schools",
                principalColumn: "SchoolID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
