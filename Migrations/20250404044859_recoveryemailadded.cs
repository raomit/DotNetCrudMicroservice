using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNetCrudMicroservice.Migrations
{
    /// <inheritdoc />
    public partial class recoveryemailadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RecoveryEmail",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecoveryEmail",
                table: "Students");
        }
    }
}
