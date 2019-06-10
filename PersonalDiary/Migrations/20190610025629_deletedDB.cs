using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalDiary.Migrations
{
    public partial class deletedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Diaries",
                table: "Diaries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diaries",
                table: "Diaries",
                column: "DiaryID")
                .Annotation("SqlServer:Clustered", true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Diaries",
                table: "Diaries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diaries",
                table: "Diaries",
                column: "DiaryID");
        }
    }
}
