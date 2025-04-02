using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PoshtaApp.Migrations
{
    /// <inheritdoc />
    public partial class initia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kraj",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kraj", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Oblasti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oblasti", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KrajId = table.Column<int>(type: "int", nullable: true),
                    OblId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Kraj_KrajId",
                        column: x => x.KrajId,
                        principalTable: "Kraj",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cities_Oblasti_OblId",
                        column: x => x.OblId,
                        principalTable: "Oblasti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Aup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Index = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    CityId = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OblId = table.Column<int>(type: "int", nullable: true),
                    OblName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KrajId = table.Column<int>(type: "int", nullable: true),
                    KrajName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aup_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aup_CityId",
                table: "Aup",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_KrajId",
                table: "Cities",
                column: "KrajId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_OblId",
                table: "Cities",
                column: "OblId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aup");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Kraj");

            migrationBuilder.DropTable(
                name: "Oblasti");
        }
    }
}
