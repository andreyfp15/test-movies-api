using Microsoft.EntityFrameworkCore.Migrations;

namespace test_movies_api.Migrations
{
    public partial class createdbsqlite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieLevels",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    idMovie = table.Column<int>(type: "INTEGER", nullable: false),
                    lvlScript = table.Column<int>(type: "INTEGER", nullable: false),
                    lvlPhotography = table.Column<int>(type: "INTEGER", nullable: false),
                    lvlSpecialEffects = table.Column<int>(type: "INTEGER", nullable: false),
                    lvlCast = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieLevels", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieLevels");
        }
    }
}
