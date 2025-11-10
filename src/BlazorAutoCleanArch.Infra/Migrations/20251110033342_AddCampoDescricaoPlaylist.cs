using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAutoCleanArch.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddCampoDescricaoPlaylist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Playlists",
                type: "TEXT",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Playlists");
        }
    }
}
