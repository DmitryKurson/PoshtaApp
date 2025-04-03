using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PoshtaApp.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Oblasti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oblasti", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rajs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rajs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<string>(type: "NVARCHAR(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RajId = table.Column<int>(type: "int", maxLength: 5, nullable: true),
                    OblId = table.Column<int>(type: "int", maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Oblasti_OblId",
                        column: x => x.OblId,
                        principalTable: "Oblasti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cities_Rajs_RajId",
                        column: x => x.RajId,
                        principalTable: "Rajs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Aup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Index = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    CityId = table.Column<string>(type: "NVARCHAR(20)", maxLength: 20, nullable: true),
                    CityName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OblId = table.Column<int>(type: "int", maxLength: 4, nullable: true),
                    OblName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    RajId = table.Column<int>(type: "int", maxLength: 5, nullable: true),
                    RajName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aup_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aup_Oblasti_OblId",
                        column: x => x.OblId,
                        principalTable: "Oblasti",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Aup_Rajs_RajId",
                        column: x => x.RajId,
                        principalTable: "Rajs",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Oblasti",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Волинська" },
                    { 756, "Харківська" },
                    { 1101, "Київська" },
                    { 1103, "Чернігівська" },
                    { 1104, "Сумська" },
                    { 1105, "Черкаська" },
                    { 1107, "Полтавська" },
                    { 1108, "Миколаївська" },
                    { 1110, "Кіровоградська" },
                    { 1119, "Херсонська" },
                    { 1127, "Луганська" }
                });

            migrationBuilder.InsertData(
                table: "Rajs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Фастівський" },
                    { 2, "Білоцерківський" },
                    { 3, "Полтавський" },
                    { 4, "Уманський" },
                    { 5, "Кам’янець-Подільський" },
                    { 6, "Драбівський" },
                    { 7, "Дергачівський" },
                    { 8, "Валківський" },
                    { 9, "Кагарлицький" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "OblId", "RajId" },
                values: new object[,]
                {
                    { "00000", "Мар’янівка", 1101, 9 },
                    { "00000007", "с. Першотравневе", 756, 8 },
                    { "0000002", "с. Кислівка", 756, 7 },
                    { "00000021", "с-ще Ягідне", 1105, 6 },
                    { "00001", "с. Білозірка", 1108, 5 },
                    { "000046", "с. Матроска", 1108, 4 },
                    { "00007124", "с. Проказине", 1101, 2 },
                    { "00009322", "с. Петренки", 1107, 3 },
                    { "000222222", "с. Рункошів", 1104, 5 },
                    { "000222223", "с. Думанів", 1104, 5 },
                    { "00063722", "с. Синьківка", 1105, 6 },
                    { "00063725", "с. Кучерівка", 1107, 3 },
                    { "0008120", "с. Садове", 1101, 1 },
                    { "00092742", "с. Новоомелькове", 1107, 3 },
                    { "00092743", "с. Омелькове", 1107, 3 },
                    { "001111", "с. Кудринці", 1104, 5 },
                    { "00112233", "м. Яслав", 1, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aup_CityId",
                table: "Aup",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Aup_OblId",
                table: "Aup",
                column: "OblId");

            migrationBuilder.CreateIndex(
                name: "IX_Aup_RajId",
                table: "Aup",
                column: "RajId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_OblId",
                table: "Cities",
                column: "OblId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_RajId",
                table: "Cities",
                column: "RajId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aup");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Oblasti");

            migrationBuilder.DropTable(
                name: "Rajs");
        }
    }
}
