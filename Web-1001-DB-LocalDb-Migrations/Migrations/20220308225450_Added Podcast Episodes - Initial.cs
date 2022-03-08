using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_1001_DB_LocalDb_Migrations.Migrations
{
    public partial class AddedPodcastEpisodesInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PodcastEpisode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<long>(type: "bigint", nullable: false),
                    ShowNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PodcastId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PodcastEpisode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PodcastEpisode_Podcasts_PodcastId",
                        column: x => x.PodcastId,
                        principalTable: "Podcasts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PodcastEpisode_PodcastId",
                table: "PodcastEpisode",
                column: "PodcastId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PodcastEpisode");
        }
    }
}
