using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddPermitImageColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PermitImage",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PermitImage",
                table: "Cars");
        }
    }
}
