using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulkyBookWeb.Migrations
{
    public partial class AddUpdatedRegModelToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Passsword",
                table: "Registrations",
                newName: "Password");

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "Registrations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "Registrations");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Registrations",
                newName: "Passsword");
        }
    }
}
