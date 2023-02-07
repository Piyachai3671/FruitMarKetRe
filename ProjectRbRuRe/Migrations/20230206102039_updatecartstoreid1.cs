using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectRbRuRe.Migrations
{
    /// <inheritdoc />
    public partial class updatecartstoreid1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CartStore",
                table: "CartStore");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "CartStore",
                newName: "IDLink");

            migrationBuilder.AlterColumn<int>(
                name: "CartStoreID",
                table: "CartStore",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "IDLink",
                table: "CartStore",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartStore",
                table: "CartStore",
                column: "CartStoreID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CartStore",
                table: "CartStore");

            migrationBuilder.RenameColumn(
                name: "IDLink",
                table: "CartStore",
                newName: "ID");

            migrationBuilder.AlterColumn<int>(
                name: "CartStoreID",
                table: "CartStore",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "CartStore",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartStore",
                table: "CartStore",
                column: "ID");
        }
    }
}
