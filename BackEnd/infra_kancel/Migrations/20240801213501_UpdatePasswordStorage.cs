using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace infra_kancel.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePasswordStorage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "ApplicationUsers",
                newName: "_passwordHash");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "_passwordHash",
                table: "ApplicationUsers",
                newName: "Password");
        }
    }
}
