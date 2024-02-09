using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KriptoCüzdan.Migrations
{
    /// <inheritdoc />
    public partial class coin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alım",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alım", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "kripto_1s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kripto_1s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Satım",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Satım", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kriptos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lot = table.Column<double>(type: "float", nullable: false),
                    değer = table.Column<double>(type: "float", nullable: false),
                    AlımId = table.Column<int>(type: "int", nullable: false),
                    SatımId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Kripto_1_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kriptos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kriptos_Alım_AlımId",
                        column: x => x.AlımId,
                        principalTable: "Alım",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kriptos_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kriptos_Satım_SatımId",
                        column: x => x.SatımId,
                        principalTable: "Satım",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kriptos_kripto_1s_Kripto_1_Id",
                        column: x => x.Kripto_1_Id,
                        principalTable: "kripto_1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kriptos_AlımId",
                table: "Kriptos",
                column: "AlımId");

            migrationBuilder.CreateIndex(
                name: "IX_Kriptos_CategoryId",
                table: "Kriptos",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Kriptos_Kripto_1_Id",
                table: "Kriptos",
                column: "Kripto_1_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Kriptos_SatımId",
                table: "Kriptos",
                column: "SatımId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kriptos");

            migrationBuilder.DropTable(
                name: "Alım");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Satım");

            migrationBuilder.DropTable(
                name: "kripto_1s");
        }
    }
}
