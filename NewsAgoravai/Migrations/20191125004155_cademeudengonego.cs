using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsAgoraVai.Migrations
{
    public partial class cademeudengonego : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NewCode",
                table: "Newss",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewCode",
                table: "Newss");
        }
    }
}
