using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace December.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class tirsdag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HousesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_Houses_HousesId",
                        column: x => x.HousesId,
                        principalTable: "Houses",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Name", "Region" },
                values: new object[,]
                {
                    { 1, "North House", "North" },
                    { 2, "South House", "South" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "HousesId", "Lastname", "Mail", "Name" },
                values: new object[,]
                {
                    { 1, null, "Doe", "john@example.com", "John" },
                    { 2, null, "Smith", "jane@example.com", "Jane" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_HousesId",
                table: "Persons",
                column: "HousesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Houses");
        }
    }
}
