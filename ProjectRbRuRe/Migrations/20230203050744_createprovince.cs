using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectRbRuRe.Migrations
{
    /// <inheritdoc />
    public partial class createprovince : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amphoe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    acode = table.Column<int>(type: "int", nullable: true),
                    aname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pcode = table.Column<int>(type: "int", nullable: true),
                    pname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amphoe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pcode = table.Column<int>(type: "int", nullable: true),
                    pname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    typesoilder = table.Column<int>(name: "type_soilder", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tambol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tcode = table.Column<int>(type: "int", nullable: true),
                    tname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    acode = table.Column<int>(type: "int", nullable: true),
                    aname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pcode = table.Column<int>(type: "int", nullable: true),
                    pname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tambol", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amphoe");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "tambol");
        }
    }
}
