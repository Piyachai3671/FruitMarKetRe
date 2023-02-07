using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectRbRuRe.Migrations
{
    /// <inheritdoc />
    public partial class reset7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OrderStoreName",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderStoreName",
                table: "Order");
        }
    }
}
