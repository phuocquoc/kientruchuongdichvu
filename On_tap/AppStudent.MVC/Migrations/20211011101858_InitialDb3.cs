using Microsoft.EntityFrameworkCore.Migrations;

namespace AppStudent.MVC.Migrations
{
    public partial class InitialDb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Class_SV_ID_Lop",
                table: "Student");

            migrationBuilder.AlterColumn<int>(
                name: "ID_Lop",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Class_SV_ID_Lop",
                table: "Student",
                column: "ID_Lop",
                principalTable: "Class_SV",
                principalColumn: "ID_Lop",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Class_SV_ID_Lop",
                table: "Student");

            migrationBuilder.AlterColumn<int>(
                name: "ID_Lop",
                table: "Student",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Class_SV_ID_Lop",
                table: "Student",
                column: "ID_Lop",
                principalTable: "Class_SV",
                principalColumn: "ID_Lop",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
