using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Dotawin.Server.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:item_type", "boots,core,neutral,situational");

            migrationBuilder.CreateTable(
                name: "DotaUpdates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Patch = table.Column<string>(type: "text", nullable: true),
                    DateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DotaUpdates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Updates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Updates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InGameItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Cost = table.Column<int>(type: "integer", nullable: false),
                    UpdateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InGameItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InGameItems_DotaUpdates_UpdateId",
                        column: x => x.UpdateId,
                        principalTable: "DotaUpdates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsCarry = table.Column<bool>(type: "boolean", nullable: false),
                    Popularity = table.Column<int>(type: "integer", nullable: false),
                    Winrate = table.Column<double>(type: "double precision", nullable: false),
                    UpdateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Heroes_Updates_UpdateId",
                        column: x => x.UpdateId,
                        principalTable: "Updates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Matches = table.Column<int>(type: "integer", nullable: false),
                    Winrate = table.Column<double>(type: "double precision", nullable: false),
                    AddedWinrate = table.Column<double>(type: "double precision", nullable: false),
                    WinratePer1000Gold = table.Column<int>(type: "integer", nullable: false),
                    InfoId = table.Column<int>(type: "integer", nullable: false),
                    HeroId = table.Column<int>(type: "integer", nullable: false),
                    UpdateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Heroes_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_InGameItems_InfoId",
                        column: x => x.InfoId,
                        principalTable: "InGameItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Updates_UpdateId",
                        column: x => x.UpdateId,
                        principalTable: "Updates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_UpdateId",
                table: "Heroes",
                column: "UpdateId");

            migrationBuilder.CreateIndex(
                name: "IX_InGameItems_UpdateId",
                table: "InGameItems",
                column: "UpdateId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_HeroId",
                table: "Items",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_InfoId",
                table: "Items",
                column: "InfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_UpdateId",
                table: "Items",
                column: "UpdateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Heroes");

            migrationBuilder.DropTable(
                name: "InGameItems");

            migrationBuilder.DropTable(
                name: "Updates");

            migrationBuilder.DropTable(
                name: "DotaUpdates");
        }
    }
}
