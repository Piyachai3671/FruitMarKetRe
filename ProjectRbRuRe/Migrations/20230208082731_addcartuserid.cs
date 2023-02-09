using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectRbRuRe.Migrations
{
    /// <inheritdoc />
    public partial class addcartuserid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CartProductUserID",
                table: "CartProduct",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CartProductUserID",
                table: "CartProduct");
        }
    }
}
