using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAutoCleanArch.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddCamposMusicaEAlbum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duracao",
                table: "Musica",
                type: "TEXT",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "CapaUrl",
                table: "Album",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duracao",
                table: "Musica");

            migrationBuilder.DropColumn(
                name: "CapaUrl",
                table: "Album");
        }
    }
}
