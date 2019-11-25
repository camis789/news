using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsAgoraVai.Migrations
{
    public partial class bilubilu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Newss",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Newss");
        }
    }
}
