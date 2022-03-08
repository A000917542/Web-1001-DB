using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_1001_DB_LocalDb_Migrations.Migrations
{
    public partial class AddedPodcastEpisodesAddedConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PodcastEpisode_Podcasts_PodcastId",
                table: "PodcastEpisode");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PodcastEpisode",
                table: "PodcastEpisode");

            migrationBuilder.RenameTable(
                name: "PodcastEpisode",
                newName: "Episodes");

            migrationBuilder.RenameIndex(
                name: "IX_PodcastEpisode_PodcastId",
                table: "Episodes",
                newName: "IX_Episodes_PodcastId");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Episodes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PodcastId",
                table: "Episodes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Episodes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Episodes",
                table: "Episodes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Podcasts_PodcastId",
                table: "Episodes",
                column: "PodcastId",
                principalTable: "Podcasts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Podcasts_PodcastId",
                table: "Episodes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Episodes",
                table: "Episodes");

            migrationBuilder.RenameTable(
                name: "Episodes",
                newName: "PodcastEpisode");

            migrationBuilder.RenameIndex(
                name: "IX_Episodes_PodcastId",
                table: "PodcastEpisode",
                newName: "IX_PodcastEpisode_PodcastId");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "PodcastEpisode",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "PodcastId",
                table: "PodcastEpisode",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PodcastEpisode",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PodcastEpisode",
                table: "PodcastEpisode",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PodcastEpisode_Podcasts_PodcastId",
                table: "PodcastEpisode",
                column: "PodcastId",
                principalTable: "Podcasts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
