using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PoshtaApp.Migrations
{
    /// <inheritdoc />
    public partial class added_raj_obl_relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OblId",
                table: "Kraj",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Kraj",
                columns: new[] { "Id", "Name", "OblId" },
                values: new object[,]
                {
                    { 1, "Шевченківський", 0 },
                    { 2, "Оболонський", 0 },
                    { 3, "Франківський", 0 },
                    { 4, "Личаківський", 0 },
                    { 5, "Приморський", 0 },
                    { 6, "Малиновський", 0 },
                    { 7, "Індустріальний", 0 },
                    { 8, "Новокодацький", 0 },
                    { 9, "Київський", 0 },
                    { 10, "Московський", 0 }
                });

            migrationBuilder.InsertData(
                table: "Oblasti",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Київська" },
                    { 2, "Львівська" },
                    { 3, "Одеська" },
                    { 4, "Дніпропетровська" },
                    { 5, "Харківська" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "KrajId", "Name", "OblId" },
                values: new object[,]
                {
                    { "1001", 1, "Київ", 1 },
                    { "1002", null, "Бровари", 1 },
                    { "2001", 3, "Львів", 2 },
                    { "2002", null, "Дрогобич", 2 },
                    { "3001", 5, "Одеса", 3 },
                    { "3002", null, "Чорноморськ", 3 },
                    { "4001", 7, "Дніпро", 4 },
                    { "4002", null, "Кам'янське", 4 },
                    { "5001", 9, "Харків", 5 },
                    { "5002", null, "Чугуїв", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kraj_OblId",
                table: "Kraj",
                column: "OblId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kraj_Oblasti_OblId",
                table: "Kraj",
                column: "OblId",
                principalTable: "Oblasti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kraj_Oblasti_OblId",
                table: "Kraj");

            migrationBuilder.DropIndex(
                name: "IX_Kraj_OblId",
                table: "Kraj");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "1001");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "1002");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "2001");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "2002");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "3001");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "3002");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "4001");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "4002");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "5001");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "5002");

            migrationBuilder.DeleteData(
                table: "Kraj",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kraj",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Kraj",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Kraj",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Kraj",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Kraj",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kraj",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Kraj",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Kraj",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Kraj",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Oblasti",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Oblasti",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Oblasti",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Oblasti",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Oblasti",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "OblId",
                table: "Kraj");
        }
    }
}
