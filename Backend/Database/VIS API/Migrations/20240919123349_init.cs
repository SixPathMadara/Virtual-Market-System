using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VIS_API.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MarketIndicators",
                columns: table => new
                {
                    IndicatorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndicatorName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketIndicators", x => x.IndicatorID);
                });

            migrationBuilder.CreateTable(
                name: "Markets",
                columns: table => new
                {
                    MarketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarketName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markets", x => x.MarketID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAge = table.Column<int>(type: "int", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarketIndicators");

            migrationBuilder.DropTable(
                name: "Markets");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
