using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppStudent.MVC.Migrations
{
    public partial class InitialDb_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ID_Lop",
                table: "Student",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Class_SV",
                columns: table => new
                {
                    ID_Lop = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameLop = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class_SV", x => x.ID_Lop);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Student_ID_Lop",
                table: "Student",
                column: "ID_Lop");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Class_SV_ID_Lop",
                table: "Student",
                column: "ID_Lop",
                principalTable: "Class_SV",
                principalColumn: "ID_Lop",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Class_SV_ID_Lop",
                table: "Student");

            migrationBuilder.DropTable(
                name: "Class_SV");

            migrationBuilder.DropIndex(
                name: "IX_Student_ID_Lop",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "ID_Lop",
                table: "Student");
        }
    }
}
